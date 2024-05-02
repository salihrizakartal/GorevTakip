using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobService
    {
        IDataResult<List<Job>> GetAll();
        IResult Add(Job job);
        IDataResult<Job> GetById(int jobId);
        IResult Update(Job job);
       
        IDataResult<List<Job>> GetAllByEmplyoeeName(string name);
        
    }
}
