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
        public static Employee SearchEmployee(Account account)
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
                    return EmployeeDAO.GetEmployeeById(idEmployee);
                }

                return null;
            }
        }

        public static Account GetEmployeesAccaunt(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetEmployeesAccaunt");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", employee.Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                Account account = null;
                while (reader.Read())
                {
                    account = new Account(int.Parse(reader["ID_Аккаунт"].ToString()),
                                                              reader["Логин"].ToString(),
                                                              reader["Пароль"].ToString());
                }

                return account;
            }
        }
    }
}
