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
                command.Parameters.Add(new SqlParameter("@idReciept", SqlDbType.Int));
                command.Parameters["@idReciept"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                reciept.Id = (int)command.Parameters["@idReciept"].Value;
            }
        }

        public static IEnumerable<Reciept> GetRecieptsByClient(Client client)
        {
            return GetReciepts(new SqlParameter("@idClient", client.Id));
        }

        public static IEnumerable<Reciept> GetRecieptsByTransport(Transport transport)
        {
            return GetReciepts(new SqlParameter("@idTransport", transport.Id));
        }

        public static IEnumerable<Reciept> GetReciepts()
        {
            return GetReciepts(null);
        }

        private static IEnumerable<Reciept> GetReciepts(SqlParameter parameter)
        {
            List<Reciept> reciepts = new List<Reciept>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetReciepts");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                if (parameter != null)
                {
                    command.Parameters.Add(parameter);
                }

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Reciept reciept = new Reciept();
                    reciept.Id                  = int.Parse(reader["ID_КвОВыдаче"].ToString());
                    int idTariff                = int.Parse(reader["Тариф"].ToString());
                    int idTransport             = int.Parse(reader["Транспорт"].ToString());
                    int idParking               = int.Parse(reader["Парковка"].ToString());
                    int idEmployee              = int.Parse(reader["Работник"].ToString());
                    int idClient                = int.Parse(reader["Клиент"].ToString());
                    reciept.CreationDate        = DateTime.Parse(reader["ДатаОформления"].ToString());
                    reciept.NecessaryReturnDate = DateTime.Parse(reader["НеобходимаяДатаВозврата"].ToString());
                    reciept.Price               = double.Parse(reader["Стоимость"].ToString());
                    int.TryParse(reader["ID_КвОВозврате"].ToString(), out int idRecieptForReturn);

                    reciept.Tariff = TariffsDAO.GetTariffById(idTariff);
                    reciept.Transport = TransportDAO.GetTransportById(idTransport);
                    reciept.Parking = ParkingDAO.GetParkingById(idParking);
                    reciept.Employee = EmployeeDAO.GetEmployeeById(idEmployee);
                    reciept.Client = ClientDAO.GetClientById(idClient);
                    reciept.RecieptForReturn = RecieptForReturnDAO.GetRecieptForReturnById(idRecieptForReturn);

                    reciepts.Add(reciept);
                }
            }

            return reciepts;
        }
    }
}
