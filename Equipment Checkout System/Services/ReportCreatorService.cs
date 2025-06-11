using Equipment_Checkout_System.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Equipment_Checkout_System.Services
{
    public class ReportCreatorService
    {
        private readonly string _connectionString;

        public ReportCreatorService()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public DataTable RunQuery(string query)
        {
            using (var conn = new OleDbConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                using (var adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
