using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipment_Checkout_System.Data;

namespace Equipment_Checkout_System.Models
{

    // Sevice class that authorizes users in relation to the database.
    public class LoginService
    {
        // Connection string for Access database is
        private readonly string _connectionString = AppConfig.ConnectionString;

        // Attempts to authenticate a user with the provided username and password.
        // Creates an Employee object if successfull.
        public Employee TryLogin(string username, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();

                    // Retrieves the query to authenticate login credentials.
                    using (OleDbCommand cmd = new OleDbCommand(AuthQueries.LoginQuery, conn))
                    {

                        // Prevents SQL Injection 
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // If credentials match, return Employee object with relevant data
                            if (reader.Read())
                            {
                                return new Employee
                                {
                                    Success = true,
                                    EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    SkillLevel = Convert.ToInt32(reader["EmployeeSkillLevel"]),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }

                // Return error if no match was found.
                return new Employee
                {
                    Success = false,
                    ErrorMessage = "Invalid user name or password."
                };
            }
            catch (Exception ex)
            {
                // return error if database error.
                return new Employee
                {
                    Success = false,
                    ErrorMessage = "Database error: " + ex.Message
                };
            }
        }
    }
}