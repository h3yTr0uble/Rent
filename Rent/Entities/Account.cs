using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        public int Id { get; }
        public Employee Employee { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
