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

        public FineReciept(double fine)
        {
            Fine = fine;
        }

        public FineReciept(int id, double fine) : this(fine)
        {
            Id = id;
        }
    }
}
