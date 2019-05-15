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
    public static class BrandDAO
    {
        public static IEnumerable<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetBrands");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    brands.Add(new Brand(int.Parse(reader["ID_Марка"].ToString()),
                                         reader["НазваниеМарки"].ToString(),
                                         double.Parse(reader["КоэфПрестижа"].ToString())));
                }
            }

            return brands;
        }
    }
}
