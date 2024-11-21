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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        //Claim

        //[SecuredOperation("job.add,admin")]
        [ValidationAspect(typeof(JobValidator))]
        [CacheRemoveAspect("IJobService.Get")]

        public IResult Add(Job job)
        {
            IResult result = BusinessRules.Run(CheckIfJobIdExists(job.JobId));

            if (result != null)
            {
                return result;
            }

            _jobDal.Add(job);

            return new SuccessResult(Messages.JobAdded);
        }

        public IDataResult<List<Job>> GetAll()
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetAll(), Messages.JobsListed);
        }

        public IDataResult<List<Job>> GetAllByEmplyoeeName(string name)
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetAll(j => j.EmplyoeeName == name));
        }

       

        public IDataResult<Job> GetById(int jobId)
        {
            return new SuccessDataResult<Job>(_jobDal.Get(j => j.JobId == jobId));
        }

       

        public IResult Update(Job job)
        {
            var result = _jobDal.GetAll(j => j.JobId == job.JobId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.JobCountOfJobError);
            }
            throw new NotImplementedException();
        }

        private IResult CheckIfJobIdExists(int jobId)
        {
            //select count(*) from products where categoryId=1
            var result = _jobDal.GetAll(j => j.JobId == jobId).Any();
            if (result)
            {
                return new ErrorResult(Messages.JobIdAlreadyExists);
            }
            return new SuccessResult();

        }
    }
}
