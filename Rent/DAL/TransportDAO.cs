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
    public static class TransportDAO
    {
        public static IEnumerable<Transport> GetTransports()
        {
            List<Transport> transports = new List<Transport>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetTransports");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Transport transport = new Transport();
                    transport.Id = int.Parse(reader["ID_Транспорт"].ToString());
                    transport.Title = reader["ГосНомер"].ToString();
                    transport.Brand = new Brand(int.Parse(reader["ID_Марка"].ToString()),
                                                reader["НазваниеМарки"].ToString());
                    transport.Model = new Model(int.Parse(reader["ID_Модель"].ToString()),
                                                reader["НазваниеМодели"].ToString());
                    transport.Color = new Color(int.Parse(reader["ID_Цвет"].ToString()),
                                                reader["НазваниеЦвета"].ToString());
                    transport.Year = int.Parse(reader["ГодВыпуска"].ToString());
                    transport.DrivingCategory = new DrivingCategory(int.Parse(reader["ID_Категория"].ToString()),
                                                                    reader["Категория"].ToString());
                    if (!string.IsNullOrEmpty(reader["ID_Парковка"].ToString()))
                    {
                        transport.Parking = new Parking(int.Parse(reader["ID_Парковка"].ToString()),
                                reader["Адрес"].ToString());
                    }

                    transport.Coef = double.Parse(reader["КоэфСтоимости"].ToString());

                    transports.Add(transport);
                }
            }

            return transports;
        }
    }
}
