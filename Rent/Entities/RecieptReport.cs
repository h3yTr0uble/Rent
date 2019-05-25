using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RecieptReport:BaseEntity
    {
        public string ClientsFullName { get; set; }
        public string TransportsTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }
    }
}
