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
    public static class ParkingDAO
    {
        public static IEnumerable<Parking> GetParkings()
        {
            List<Parking> parkings = new List<Parking>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetParkings");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    parkings.Add(new Parking(int.Parse(reader["ID_Парковка"].ToString()),
                                             reader["Адрес"].ToString()));
                }
            }

            return parkings;
        }

        internal static Parking GetParkingById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetParkingByID");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Parking parking = new Parking(id, (string)reader["Адрес"]);

                        return parking;
                    }
                }
            }

            return null;
        }
    }
}
