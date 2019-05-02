using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Position
    {
        public int Id { get; }
        public string Title { get; set; }

        public Position()
        {
        }

        public Position(string title)
        {
            Title = title;
        }

        public Position(int id, string title):this(title)
        {
            Id = id;
        }
    }
}
