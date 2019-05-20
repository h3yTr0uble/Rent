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
    public static class AccountDAO
    {
        public static void SearchEmployee(Account account)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("Login");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@log", account.Login);
                command.Parameters.AddWithValue("@pass", account.Password);
                command.Parameters.Add(new SqlParameter("@idEmployee", SqlDbType.Int));
                command.Parameters["@idEmployee"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                if (int.TryParse(command.Parameters["@idEmployee"].Value.ToString(), out int idEmployee))
                {
                    account.Employee = EmployeeDAO.GetEmployeeById(idEmployee);
                }
            }
        }
    }
}
