using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ActualConnectionString
    {
        private static string connectionString;

        public static string Get()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                ActualConnectionString.SetDefault();
            }

            return connectionString;
        }

        public static string GetMaster()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionStringMaster"].ConnectionString;
        }

        public static void Set(string connectionString)
        {
            ActualConnectionString.connectionString = connectionString;
        }

        public static void SetDefault()
        {
            ActualConnectionString.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
        }
    }
}
