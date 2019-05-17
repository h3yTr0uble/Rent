using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tariff:StandartdEntity
    {
        public int Interval { get; set; }
        public double Price { get; set; }

        public Tariff(int id, string title, int interval, double price):base(id, title)
        {
            Interval = interval;
            Price = price;
        }
    }
}
