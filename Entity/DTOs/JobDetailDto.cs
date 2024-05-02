using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class JobDetailDto : IDto
    {
        public int JobId { get; set; }

        public string PowerPlantName { get; set; }
        public string City { get; set; }
        public DateTime JobDate { get; set; }
        public string TestName { get; set; }
        public string EmplyoeeName { get; set; }
        
    }
}
