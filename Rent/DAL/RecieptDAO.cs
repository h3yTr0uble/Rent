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
    public static class RecieptDAO
    {
        public static void Add(Reciept reciept)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("AddReciept");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@tariff", reciept.Tariff.Id);
                command.Parameters.AddWithValue("@transport", reciept.Transport.Id);
                command.Parameters.AddWithValue("@parking", reciept.Parking.Id);
                command.Parameters.AddWithValue("@employee", reciept.Employee.Id);
                command.Parameters.AddWithValue("@client", reciept.Client.Id);
                command.Parameters.AddWithValue("@creationDate", reciept.CreationDate);
                command.Parameters.AddWithValue("@necessaryReturnDate", reciept.NecessaryReturnDate);
                command.Parameters.AddWithValue("@price", reciept.Price);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
