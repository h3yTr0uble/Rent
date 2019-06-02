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
    public static class PositionDAO
    {
        public static IEnumerable<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetPositions");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    positions.Add(new Position(int.Parse(reader["ID_Должность"].ToString()),
                                         reader["НазваниеДолжности"].ToString()));
                }
            }

            return positions;
        }
    }
}
