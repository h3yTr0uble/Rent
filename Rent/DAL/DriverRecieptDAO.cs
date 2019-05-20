using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DriverRecieptDAO
    {
        public static void Add(DriverReciept driverReciept)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("AddDriverReciept");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@idReciept", driverReciept.Reciept.Id);
                command.Parameters.AddWithValue("@idEmployee", driverReciept.Driver.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
