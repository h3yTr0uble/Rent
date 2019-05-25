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
    public static class ParkingAttendanceReportDAO
    {
        public static IEnumerable<ParkingAttendancePerort> GetParkingsAttendance(DateTime fromDate, DateTime toDate)
        {
            List<ParkingAttendancePerort> parkingsAttendance = new List<ParkingAttendancePerort>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetParkingsAttendanceReport");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    parkingsAttendance.Add(new ParkingAttendancePerort(reader["Адрес"].ToString(),
                        int.Parse(reader["КоличествоПосещений"].ToString())));
                }
            }

            return parkingsAttendance;
        }
    }
}
