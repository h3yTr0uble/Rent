using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Position:StandartdEntity
    {
        public Position(int id, string title) : base(id, title)
        { }

        public Position()
        {
        }

        public Position(string title):base(title)
        {
        }
    }
}
