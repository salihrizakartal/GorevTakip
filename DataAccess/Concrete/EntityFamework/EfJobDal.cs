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
    public class EfJobDal : EfEntityRepositoryBase<Job, JobContext>, IJobDal
    {
        public List<JobDetailDto> GetJobDetails()
        {
            using (JobContext context = new JobContext())
            {
                var result = from j in context.Jobs

                             select new JobDetailDto
                             {
                                 JobId = j.JobId,
                                 JobDate = j.JobDate,
                                 EmplyoeeName = j.EmplyoeeName,     
                                 TestName = j.TestName,
                                 PowerPlantName = j.PowerPlantName,
                                 City = j.City

                             };
                return result.ToList();
            }
        }
    }
}
