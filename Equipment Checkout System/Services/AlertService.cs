using Equipment_Checkout_System.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Services
{
    /// <summary>
    /// Provides functionality to detect and retrieve overdue equipment
    /// checked out by employees.
    /// </summary>
    public class AlertService
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of "AlertService".
        /// </summary>
        /// <param name="connectionString">
        /// OleDb connection string used to access the ECS database.
        /// </param>
        public AlertService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<(string ToolName, DateTime ReturnBy, int DaysLate)> GetOverdueTools(int employeeId)
        {
            var list = new List<(string, DateTime, int)>();
            using var conn = new OleDbConnection(_connectionString);
            using var cmd = new OleDbCommand(AlertQueries.LateToolAlert, conn);
            cmd.Parameters.AddWithValue("?", employeeId);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add((
                    reader.GetString(1),
                    reader.GetDateTime(2),
                    reader.GetInt32(3)
                ));
            }
            return list;
        }

    }
}
