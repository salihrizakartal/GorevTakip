using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITestService
    {
        IDataResult<List<Test>> GetAll();
        IResult Add(Test test);
        IDataResult<Test> GetById(int testId);
        IResult Update(Test test);
    }
}
