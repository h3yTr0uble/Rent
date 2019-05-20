using System;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Entities;

namespace DAL
{
    public class FineRecieptDAO
    {
        public static void Add(RecieptForReturn recieptForReturn)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("AddFineReciept");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@idRecieptForReturn", recieptForReturn.Id);
                command.Parameters.AddWithValue("@fine", recieptForReturn.FineReciept.Fine);
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Parameters["@id"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                recieptForReturn.FineReciept.Id = (int)command.Parameters["@id"].Value;
            }
        }
    }
}