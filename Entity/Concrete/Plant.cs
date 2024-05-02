using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Plant:IEntity
    {
        [Key]  public int PowerPlantId { get; set; }
        

        public string PowerPlantName { get; set; }
        public string City { get; set; }
        public string PowerPlantType { get; set; }
        public int NumberOfUnits { get; set; }
        public int PowerPlantPower { get; set; }

    }
}
