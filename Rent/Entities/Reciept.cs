using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reciept:BaseEntity
    {
        public Transport Transport { get; set; }
        public Client Client { get; set; }
        public Tariff Tariff { get; set; }
        public Parking Parking { get; set; }
        public Employee Employee { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime NecessaryReturnDate { get; set; }
        public double Price { get; set; }

        public RecieptForReturn RecieptForReturn { get; set; }
    }
}
