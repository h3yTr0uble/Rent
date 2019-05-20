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
    public static class RecieptForReturnDAO
    {
        public static RecieptForReturn GetRecieptForReturnById(int id)
        {
            if (id == 0)
            {
                return null;
            }

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetRecieptForReturnById");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecieptForReturn recieptForReturn = new RecieptForReturn();

                        recieptForReturn.Id = int.Parse(reader["ID_КвОВозврате"].ToString());
                        int idParking       = int.Parse(reader["Парковка"].ToString());
                        recieptForReturn.CreationDate = DateTime.Parse(reader["ДатаОформления"].ToString());
                        if (!string.IsNullOrEmpty(reader["ID_КвШтраф"].ToString()))
                        {
                            recieptForReturn.FineReciept = new FineReciept(int.Parse(reader["ID_КвШтраф"].ToString()),
                                                                       double.Parse(reader["Штраф"].ToString()));
                        }

                        recieptForReturn.Parking = ParkingDAO.GetParkingById(idParking);
                        return recieptForReturn;
                    }
                }
            }

            return null;
        }
    }
}
