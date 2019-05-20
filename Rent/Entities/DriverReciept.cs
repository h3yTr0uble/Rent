using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DriverReciept : BaseEntity
    {
        public Reciept Reciept { get; set; }
        public Employee Driver { get; set; }
    }
}
