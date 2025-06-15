using Equipment_Checkout_System.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Equipment_Checkout_System.Services
{
    public class EmployeeServices
    {
        // Holds database connection string
        private readonly string _connStr;
        public EmployeeServices(string connectionString)
        {
            _connStr = connectionString;
        }

        //Checks if Username Exists
        public bool UserNameExists(string userName)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(DepotQueries.CheckUsernameExists, conn);
            cmd.Parameters.AddWithValue("?", userName);
            return (int)cmd.ExecuteScalar() > 0;
        }

        public void AddEmployee(string firstName, string lastName, string username, string password, int skillLevel, string role)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(DepotQueries.InsertEmployee, conn);
            cmd.Parameters.AddWithValue("?", firstName);
            cmd.Parameters.AddWithValue("?", lastName);
            cmd.Parameters.AddWithValue("?", username);
            cmd.Parameters.AddWithValue("?", password);
            cmd.Parameters.AddWithValue("?", skillLevel);
            cmd.Parameters.AddWithValue("?", role);
            cmd.ExecuteNonQuery();
        }

        

    }
}
