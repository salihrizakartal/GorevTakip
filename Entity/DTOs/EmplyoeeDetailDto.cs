using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmplyoeeDetailDto : IDto
    {
       

        public int RegistrationId { get; set; }

        public string Department { get; set; }
        public string EmplyoeeName { get; set; }
        
        public string Position { get; set; }
    }
}
