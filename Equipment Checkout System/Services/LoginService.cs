using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Models
{


    public class LoginService
    {
        private readonly string _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ECSCEIS400.accdb";

        public Employee TryLogin(string username, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM EmployeesList WHERE UserName = ? AND EmployeePassword = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Employee
                                {
                                    Success = true,
                                    EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }

                return new Employee
                {
                    Success = false,
                    ErrorMessage = "Invalid user name or password."
                };
            }
            catch (Exception ex)
            {
                return new Employee
                {
                    Success = false,
                    ErrorMessage = "Database error: " + ex.Message
                };
            }
        }
    }
}