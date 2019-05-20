using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class AccessoryRecient:BaseEntity
    {
        public Reciept Reciept { get; set; }
    }
}
