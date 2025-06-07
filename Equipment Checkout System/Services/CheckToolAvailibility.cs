using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Equipment_Checkout_System.Services
{
    internal class CheckToolAvailibility
    {
        private readonly string _connectionString;

        public CheckToolAvailibility(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets a list of EquipmentIDs that are currently available for checkout.
        /// </summary>
        public List<int> GetAvailableToolIds()
        {
            var availableTools = new List<int>();

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                // Get all EquipmentIDs from Tools table
                string allToolsQuery = "SELECT EquipmentID FROM Tools";
                var allToolIds = new List<int>();
                using (OleDbCommand cmd = new OleDbCommand(allToolsQuery, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allToolIds.Add(reader.GetInt32(0));
                    }
                }

                // Get EquipmentIDs that are still checked out (ConditionIn is NULL or 'Not Returned')
                string checkedOutQuery = @"
                    SELECT EquipmentID FROM Checkouts
                    WHERE [ConditionIn] IS NULL OR [ConditionIn] = 6";

                var checkedOutIds = new HashSet<int>();
                using (OleDbCommand cmd = new OleDbCommand(checkedOutQuery, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedOutIds.Add(reader.GetInt32(0));
                    }
                }

                // Available = All tools - Checked out tools
                foreach (var toolId in allToolIds)
                {
                    if (!checkedOutIds.Contains(toolId))
                    {
                        availableTools.Add(toolId);
                    }
                }
            }

            return availableTools;
        }
    }
}