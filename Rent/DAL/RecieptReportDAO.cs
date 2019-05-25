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
    public static class RecieptReportDAO
    {
        public static IEnumerable<RecieptReport> GetRecieptsReport(DateTime fromDate, DateTime toDate)
        {
            List<RecieptReport> recieptsReport = new List<RecieptReport>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetRecieptsReport");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RecieptReport recieptReport = new RecieptReport();
                    recieptReport.Id = int.Parse(reader["ID_КвОВыдаче"].ToString());
                    recieptReport.ClientsFullName = reader["ФИО"].ToString();
                    recieptReport.TransportsTitle = reader["ГосНомер"].ToString();
                    recieptReport.CreationDate = DateTime.Parse(reader["ДатаОформления"].ToString());
                    recieptReport.Price = double.Parse(reader["Стоимость"].ToString());

                    recieptsReport.Add(recieptReport);
                }
            }

            return recieptsReport;
        }
    }
}
