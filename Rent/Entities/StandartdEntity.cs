using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class StandartdEntity:BaseEntity
    {
        public string Title { get; set; }

        public StandartdEntity(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public StandartdEntity(string title)
        {
            Title = title;
        }

        public StandartdEntity()
        {
        }

        public override string ToString()
        {
            return Title;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
    }
}
