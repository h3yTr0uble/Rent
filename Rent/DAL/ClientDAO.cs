﻿using BLL;
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
    public class ClientDAO
    {
        public static IEnumerable<Client> GetClients()
        {
            List<Client> сlients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetClients");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id        = int.Parse(reader["ID_Клиент"].ToString());
                    client.Passport  = reader["Паспорт"].ToString();
                    client.FullName  = reader["ФИО"].ToString();
                    client.Phone     = reader["Телефон"].ToString();

                    client.AddDrivingCategory(DrivingCategoryDAO.GetClientsDrivingCategories(client));

                    сlients.Add(client);
                }
            }

            return сlients;
        }
    }
}
