using Equipment_Checkout_System.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Services
{
    public class ToolServices
    {
        private readonly string _connStr;

        public ToolServices(string connectionString)
        {
            _connStr = connectionString;
        }

        public void AddTool(string name, decimal price, int skillRequired)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(ToolQueries.InsertTool, conn);
            cmd.Parameters.AddWithValue("?", name);
            cmd.Parameters.AddWithValue("?", price);
            cmd.Parameters.AddWithValue("?", skillRequired);
            cmd.ExecuteNonQuery();
        }
    }
}
