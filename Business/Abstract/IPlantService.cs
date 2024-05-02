using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlantService
    {
        IDataResult<List<Plant>> GetAll();
        IResult Add(Plant plant);
        IDataResult<Plant> GetById(int plantId);
        IResult Update(Plant plant);
    }
}
