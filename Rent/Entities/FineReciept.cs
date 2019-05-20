using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FineReciept : BaseEntity
    {
        public double Fine { get; set; }

        public FineReciept(int id, double fine)
        {
            Id = id;
            Fine = fine;
        }
    }
}
