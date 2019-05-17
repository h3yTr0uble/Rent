using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entities;

namespace DAL
{
    public class TariffsDAO
    {
        public static IEnumerable<Tariff> GetTariffs()
        {
            List<Tariff> tariffs = new List<Tariff>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetTariffs");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tariffs.Add(new Tariff(int.Parse(reader["ID_Тариф"].ToString()),
                                         reader["Название"].ToString(),
                                         int.Parse(reader["СрокАренды"].ToString()),
                                         double.Parse(reader["СтоимостьЗаЧас"].ToString())));
                }
            }

            return tariffs;
        }
    }
}
