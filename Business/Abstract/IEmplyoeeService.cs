using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmplyoeeService
    {
        IDataResult<List<Emplyoee>> GetAll();
        IResult Add(Emplyoee emplyoee);
        IDataResult<Emplyoee> GetById(int registrationId);
        IResult Update(Emplyoee emplyoee);
        IResult Delete (Emplyoee emplyoee);

    }
}
