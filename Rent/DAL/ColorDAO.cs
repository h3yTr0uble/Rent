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
    public static class ColorDAO
    {
        public static IEnumerable<Color> GetColors()
        {
            List<Color> colors = new List<Color>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetColors");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colors.Add(new Color(int.Parse(reader["ID_Цвет"].ToString()),
                                                reader["НазваниеЦвета"].ToString()));
                }
            }

            return colors;
        }
    }
}
