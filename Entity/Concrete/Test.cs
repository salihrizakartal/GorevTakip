using Core.Entities;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Test: IEntity
    {
       
        public int TestId { get; set; }

        public string TestName { get; set; }
    }
}
