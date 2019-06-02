using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee:Person
    {
        public Position Position { get; set; }
        public Account Account { get; set; }

        public Employee(int id, string passport, string fullName):base(id, passport, fullName)
        { }

        public Employee()
        {

        }
    }
}
