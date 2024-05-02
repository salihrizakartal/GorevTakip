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
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmplyoeeManager : IEmplyoeeService
    {

        IEmplyoeeDal _emplyoeeDal;
        private string emplyoeeName;

        public EmplyoeeManager(IEmplyoeeDal emplyoeeDal)
        {
            _emplyoeeDal = emplyoeeDal;
        }

        //Claim

        [SecuredOperation("emplyoee.add,admin")]
        [ValidationAspect(typeof(EmplyoeeValidator))]
        [CacheRemoveAspect("IEmplyoeeService.Get")]


        public IResult Add(Emplyoee emplyoee)
        {
            IResult result = BusinessRules.Run(CheckIfEmplyoeeNameExists(emplyoee.EmplyoeeName));

            if (result != null)
            {
                return result;
            }

            _emplyoeeDal.Add(emplyoee);

            return new SuccessResult(Messages.EmplyoeeAdded);
        }
        [SecuredOperation("emplyoee.delete,admin")]
        public IResult Delete(Emplyoee emplyoee)
        {
            var result = BusinessRules.Run(CheckIfEmplyoeeNameExists(emplyoee.EmplyoeeName));
            if (result == null)
            {
                _emplyoeeDal.Delete(emplyoee);
            }
       
            return new SuccessResult(Messages.EmplyoeeDeleted);

        }

       
       

        public IDataResult<List<Emplyoee>> GetAll()
        {
            return new SuccessDataResult<List<Emplyoee>>(_emplyoeeDal.GetAll(), Messages.EmplyoeesListed);
        }

        public IDataResult<Emplyoee> GetById(int registrationId)
        {
            return new SuccessDataResult<Emplyoee>(_emplyoeeDal.Get(e => e.RegistrationId == registrationId));
        }
        [SecuredOperation("emplyoee.update,admin")]
        public IResult Update(Emplyoee emplyoee)
        {
            var result = _emplyoeeDal.GetAll(e => e.RegistrationId == emplyoee.RegistrationId).Count;
            if (result > 0)
            {
                _emplyoeeDal.Update(emplyoee);
            }else
            {
                return new ErrorResult(Messages.EmplyoeeNotFound);
            }
            return new ErrorResult(Messages.EmplyoeeUpdated);
        }

        private IResult CheckIfEmplyoeeNameExists(string EmplyoeeName)
        {
            //select count(*) from products where categoryId=1
            var result = _emplyoeeDal.GetAll(e => e.EmplyoeeName == emplyoeeName).Any();
            if (result)
            {
                return new ErrorResult(Messages.EmplyoeeNameAlreadyExists);
            }
            return new SuccessResult();

        }

    }
}
