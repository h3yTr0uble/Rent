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
    public static class TransportReportDAO
    {
        public static IEnumerable<TransportReport> GetTransportHours(DateTime fromDate, DateTime toDate)
        {
            List<TransportReport> transportReport = new List<TransportReport>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetRelevanceTransportHoursReport");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transportReport.Add(new TransportReport(reader["ГосНомер"].ToString(),
                        double.Parse(reader["calculatedParam"].ToString())));
                }
            }

            return transportReport;
        }

        public static IEnumerable<TransportReport> GetTransportHoursCoef(DateTime fromDate, DateTime toDate)
        {
            List<TransportReport> transportReport = new List<TransportReport>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetRelevanceTransportHoursCoefReport");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transportReport.Add(new TransportReport(reader["ГосНомер"].ToString(),
                        double.Parse(reader["calculatedParam"].ToString())));
                }
            }

            return transportReport;
        }
    }
}
