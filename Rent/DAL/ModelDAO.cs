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
    public static class ModelDAO
    {
        public static IEnumerable<Model> GetModels()
        {
            List<Model> models = new List<Model>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetModels");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    models.Add(new Model(int.Parse(reader["ID_Модель"].ToString()),
                                         reader["НазваниеМодели"].ToString(),
                                         int.Parse(reader["ID_Марка"].ToString()),
                                         reader["НазваниеМарки"].ToString(),
                                         double.Parse(reader["КоэфПрестижа"].ToString())));
                }
            }

            return models;
        }
    }
}
