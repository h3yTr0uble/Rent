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
        public static void Add(Reciept reciept)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("AddDriverReciept");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@idReciept", reciept.Id);
                command.Parameters.AddWithValue("@idEmployee", reciept.DriverReciept.Driver.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        internal static DriverReciept GetDriverRecieptById(int id)
        {
            if (id == 0)
            {
                return null;
            }

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetDriverRecieptById");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DriverReciept driverReciept = new DriverReciept();

                        driverReciept.Id = int.Parse(reader["ID_КвВодитель"].ToString());
                        int idDriver = int.Parse(reader["Работник"].ToString());

                        driverReciept.Driver = EmployeeDAO.GetEmployeeById(idDriver);
                        return driverReciept;
                    }
                }
            }

            return null;
        }
    }
}
