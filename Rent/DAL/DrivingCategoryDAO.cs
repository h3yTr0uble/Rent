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
    public static class DrivingCategoryDAO
    {
        public static IEnumerable<DrivingCategory> GetDrivingCategories()
        {
            List<DrivingCategory> drivingCategories = new List<DrivingCategory>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetDrivingCategories");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    drivingCategories.Add(new DrivingCategory(int.Parse(reader["ID_Категория"].ToString()),
                                                              reader["Категория"].ToString(),
                                                              int.Parse(reader["КодТипа"].ToString()),
                                                              reader["НазваниеТипа"].ToString()));
                }
            }

            return drivingCategories;
        }

        public static IEnumerable<DrivingCategory> GetClientsDrivingCategories(Client client)
        {
            List<DrivingCategory> drivingCategories = new List<DrivingCategory>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetClientsDrivingCategories");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", client.Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    drivingCategories.Add(new DrivingCategory(int.Parse(reader["ID_Категория"].ToString()),
                                                              reader["Категория"].ToString()));
                }
            }

            return drivingCategories;
        }

        internal static IEnumerable<DrivingCategory> GetEmployeesDrivingCategories(Employee employee)
        {
            List<DrivingCategory> drivingCategories = new List<DrivingCategory>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetEmployeesDrivingCategories");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", employee.Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    drivingCategories.Add(new DrivingCategory(int.Parse(reader["ID_Категория"].ToString()),
                                                              reader["Категория"].ToString()));
                }
            }

            return drivingCategories;
        }
    }
}
