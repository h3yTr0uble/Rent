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
    public static class EmployeeDAO
    {
        public static IEnumerable<Employee> GetDrivers(Transport transport)
        {
            List<Employee> drivers = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetDrivers");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@drivingCategory", transport.DrivingCategory.Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee driver = new Employee();
                    driver.Id = int.Parse(reader["ID_Работник"].ToString());
                    driver.Passport = reader["Паспорт"].ToString();
                    driver.FullName = reader["ФИО"].ToString();
                    driver.Phone = reader["Телефон"].ToString();

                    drivers.Add(driver);
                }
            }

            return drivers;
        }

        public static Employee GetEmployeeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetEmployeeByID");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee(id, (string)reader["Паспорт"], (string)reader["ФИО"]);
                        return employee;
                    }
                }
            }

            return null;
        }

        public static IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(ActualConnectionString.Get()))
            {
                SqlCommand command = new SqlCommand("GetEmployees");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = int.Parse(reader["ID_Работник"].ToString());
                    employee.Passport = reader["Паспорт"].ToString();
                    employee.FullName = reader["ФИО"].ToString();
                    employee.Phone = reader["Телефон"].ToString();
                    employee.Position = new Position(int.Parse(reader["ID_Должность"].ToString()),
                                                     reader["НазваниеДолжности"].ToString());

                    employees.Add(employee);
                }
            }

            return employees;
        }

        public static void Edit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public static void Add(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
