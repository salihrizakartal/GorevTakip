using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFamework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlantManager : IPlantService
    {
        IPlantDal _plantDal;
        

        public PlantManager (IPlantDal plantDal)
        {
            _plantDal = plantDal;
        }

        //Claim

        [SecuredOperation("plant.add,admin")]
        [ValidationAspect(typeof(PlantValidator))]
        [CacheRemoveAspect("IPlantService.Get")]
        public IResult Add(Plant plant)
        {
            IResult result = BusinessRules.Run(CheckIfPlantNameExists(plant.PowerPlantName));

            if (result != null)
            {
                return result;
            }

            _plantDal.Add(plant);

            return new SuccessResult(Messages.PlantAdded);
        }

        public IDataResult<List<Plant>> GetAll()
        {
            return new SuccessDataResult<List<Plant>>(_plantDal.GetAll(), Messages.PlantsListed);
        }

        public IDataResult<Plant> GetById(int powerplantId)
        {
            return new SuccessDataResult<Plant>(_plantDal.Get(p => p.PowerPlantId == powerplantId));
        }

        public IResult Update(Plant plant)
        {
            var result = _plantDal.GetAll(p => p.PowerPlantId== plant.PowerPlantId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.EmplyoeeCountOfEmplyoeeError);
            }
            throw new NotImplementedException();
        }

        private IResult CheckIfPlantNameExists(string powerPlantName)
        {
            //select count(*) from products where categoryId=1
            var result = _plantDal.GetAll(p => p.PowerPlantName == powerPlantName).Any();
            if (result)
            {
                return new ErrorResult(Messages.PlantNameAlreadyExists);
            }
            return new SuccessResult();

        }
    }
}
