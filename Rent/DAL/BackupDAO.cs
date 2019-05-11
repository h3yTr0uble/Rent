using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BackupDAO
    {
        public static void CreateBackup(string path)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("CreateBackup");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@path", path);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void RestoreDatabase(string databaseName, string path)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.GetMaster()))
            {
                string commandText = string.Format(@"ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                                                      RESTORE DATABASE [{0}] FROM  DISK = N'{1}' WITH  FILE = 1, NOUNLOAD, REPLACE, STATS = 5
                                                      ALTER DATABASE [{0}] SET MULTI_USER",
                                                      databaseName,
                                                      path);
                SqlCommand command = new SqlCommand(commandText);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
