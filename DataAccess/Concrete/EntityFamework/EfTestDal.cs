using Core.DataAccess;
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
    public class EfTestDal : EfEntityRepositoryBase<Test, JobContext>, ITestDal
    {
        public List<TestDetailDto> GetTestDetails()
        {
            using (JobContext context = new JobContext())
            {
                var result = from t in context.Tests

                             select new TestDetailDto
                             {
                                 TestId = t.TestId,
                                 TestName = t.TestName,
                               
                             };
                return result.ToList();
            }
        }
    }
}
