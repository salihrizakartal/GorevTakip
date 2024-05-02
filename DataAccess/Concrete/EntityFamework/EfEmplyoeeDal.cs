using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFamework
{
    public class EfEmplyoeeDal : EfEntityRepositoryBase<Emplyoee, JobContext>, IEmplyoeeDal
    {
        public List<EmplyoeeDetailDto> GetEmplyoeeDetails()
        {
            using (JobContext context = new JobContext())
            {
                var result = from e in context.Emplyoees
                           
                             select new EmplyoeeDetailDto
                             {
                                
                                 RegistrationId = e.RegistrationId,
                                 Department = e.Department,
                                 EmplyoeeName = e.EmplyoeeName,
                                 Position = e.Position
                             };
                return result.ToList();
            }
        }
    }
}
