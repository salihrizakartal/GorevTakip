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
    public class TestManager : ITestService
    {
        ITestDal _testDal;

        public TestManager(ITestDal testDal)
        {
            _testDal = testDal;
        }

        //Claim

        [SecuredOperation("test.add,admin")]
        [ValidationAspect(typeof(TestValidator))]
        [CacheRemoveAspect("ITestService.Get")]

        public IResult Add(Test test)
        {
            IResult result = BusinessRules.Run(CheckIfTestNameExists(test.TestName));

            if (result != null)
            {
                return result;
            }

            _testDal.Add(test);

            return new SuccessResult(Messages.TestAdded);
        }

        public IDataResult<List<Test>> GetAll()
        {
            return new SuccessDataResult<List<Test>>(_testDal.GetAll(), Messages.TestsListed);
        }

        public IDataResult<Test> GetById(int testId)
        {
            return new SuccessDataResult<Test>(_testDal.Get(t => t.TestId == testId));
        }

        public IResult Update(Test test)
        {
            var result = _testDal.GetAll(j => j.TestId == test.TestId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.TestCountOfTestError);
            }
            throw new NotImplementedException();
        }
        private IResult CheckIfTestNameExists(string testName)
        {
            //select count(*) from products where categoryId=1
            var result = _testDal.GetAll(t => t.TestName == testName).Any();
            if (result)
            {
                return new ErrorResult(Messages.TestNameAlreadyExists);
            }
            return new SuccessResult();

        }
    }
}
