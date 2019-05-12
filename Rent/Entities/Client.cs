using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client:Person
    {
        public Client()
        { }

        public Client(int id, string passport, string fullName):base(id, passport, fullName)
        { }
    }
}
