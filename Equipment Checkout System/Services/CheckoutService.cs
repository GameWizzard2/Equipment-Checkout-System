using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Services
{
    public class CheckoutService
    {

        private readonly string _connectionString;

        public CheckoutService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CheckOutTool(int employeeId, int equipmentId, DateTime checkedOut, DateTime returnBy, string conditionOut)
        {
            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                string insertQuery = @"
                INSERT INTO Checkouts (EmployeeID, EquipmentID, CheckedOut, ReturnBy, ConditionOut)
                VALUES (?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", employeeId);
                    cmd.Parameters.AddWithValue("?", equipmentId);
                    cmd.Parameters.AddWithValue("?", checkedOut);
                    cmd.Parameters.AddWithValue("?", returnBy);
                    cmd.Parameters.AddWithValue("?", conditionOut);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CheckInTool(int equipmentId, int employeeId, int conditionIn, DateTime checkedIN)
        {
            using (var conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE Checkouts
                    SET [CheckedIN] = ?, [ConditionIn] = ?, [ReturnedBy] = ?
                    WHERE [EquipmentID] = ? AND [EmployeeID] = ? AND [CheckedIN] IS NULL";

                using (var cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.Add("?", OleDbType.Date).Value = checkedIN;        // CheckedIN
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = conditionIn;   // ConditionIn (e.g., 2 = Good)
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = employeeId;    // ReturnedBy
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = equipmentId;   // EquipmentID
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = employeeId;    // EmployeeID

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }




}
