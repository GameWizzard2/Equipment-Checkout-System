using Equipment_Checkout_System.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Equipment_Checkout_System.Services
{
    internal class CheckToolAvailibility
    {
        private readonly string _connectionString;
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ECSCEIS400.accdb";

        public CheckToolAvailibility(string connectionString)
        {
            _connectionString = connStr;
        }

        /// Gets a list of tools (ID and name) that are available for checkout.
        public List<ToolInfo> GetAvailableTools()
        {
            var availableTools = new List<ToolInfo>();
            var allTools = new Dictionary<int, string>();

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                // Load all tools and their names
                string allToolsQuery = "SELECT EquipmentID, [EquipmentName] FROM Tools";
                using (OleDbCommand cmd = new OleDbCommand(allToolsQuery, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        allTools[id] = name;
                    }
                }

                // Get equipment IDs that are checked out and not returned (ConditionIn is NULL or status code 6)
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

                // Build list of tools that are not checked out
                foreach (var kvp in allTools)
                {
                    if (!checkedOutIds.Contains(kvp.Key))
                    {
                        availableTools.Add(new ToolInfo
                        {
                            EquipmentID = kvp.Key,
                            EquipmentName = kvp.Value
                        });
                    }
                }
            }

            return availableTools;
        }
    }
}
