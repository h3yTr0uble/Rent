using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Passport { get; set; }
        public Position Position { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public Employee(int id, string passport, string fullName)
        {
            Id = id;
            Passport = passport;
            FullName = fullName;
        }
    }
}
