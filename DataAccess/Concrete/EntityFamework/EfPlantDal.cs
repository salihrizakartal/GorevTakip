using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFamework
{
    public class EfPlantDal : EfEntityRepositoryBase<Plant, JobContext>,IPlantDal 
    {
       
        public List<PlantDetailDto> GetPlantDetails()
        {
            using (JobContext context = new JobContext())
            {
                var result = from p in context.Plants

                             select new PlantDetailDto
                             {
                                 PowerPlantId = p.PowerPlantId,
                                 PowerPlantName = p.PowerPlantName,
                                 PowerPlantPower = p.PowerPlantPower,
                                 PowerPlantType = p.PowerPlantType,
                                 NumberOfUnits = p.NumberOfUnits,
                                 City = p.City,
                             };
                return result.ToList();
            }
        }

      
    }
}
