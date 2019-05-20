using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RecieptForReturn : BaseEntity
    {
        public Parking Parking { get; set; }
        public DateTime CreationDate { get; set; }
        public FineReciept FineReciept { get; set; }
    }
}
