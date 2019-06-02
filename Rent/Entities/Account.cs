using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account:BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Account(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }

        public Account()
        {
        }
    }
}
