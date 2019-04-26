using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConnectionStringInfo
    {
        public string DataSource { get; }
        public string InitialCatalog { get; }
        public bool IntegratedSecurity { get; }
        public string UserID { get; }
        public string Password { get; }

        public ConnectionStringInfo(string conString)
        {
            char[] separator = { ';' };
            string[] properties = conString.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string property in properties)
            {
                string[] values = property.Split('=');
                switch (values[0])
                {
                    case "Data Source":
                        DataSource = values[1];
                        break;
                    case "Initial Catalog":
                        InitialCatalog = values[1];
                        break;
                    case "Integrated Security":
                        IntegratedSecurity = bool.Parse(values[1]);
                        break;
                    case "User ID":
                        UserID = values[1];
                        break;
                    case "Password":
                        Password = values[1];
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
