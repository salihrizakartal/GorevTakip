
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Emplyoee:IEntity
    {
        
        [Key]
        public int RegistrationId { get; set; }

        public string Department { get; set; }
        public string EmplyoeeName { get; set; }
       
        public string Position { get; set; }

       
    }
}
