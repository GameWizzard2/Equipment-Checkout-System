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
            _connectionString = connectionString;
        }

        /// Gets a list of tools (ID and name) that are available for checkout.
        public List<ToolInfo> GetAvailableTools(int employeeSkillLevel)
        {
            var availableTools = new List<ToolInfo>();
            var allTools = new Dictionary<int, Tuple<string, int>>(); // ID, (Name, SkillRequired)

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                // 1. Load all tools and required skill level
                string allToolsQuery = "SELECT EquipmentID, EquipmentName, SkillRequired FROM Tools";
                using (OleDbCommand cmd = new OleDbCommand(allToolsQuery, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int skillRequired = reader.GetInt32(2);
                        allTools[id] = Tuple.Create(name, skillRequired);
                    }
                }

                // 2. Load checked out equipment IDs
                string checkedOutQuery = @"
                    SELECT EquipmentID FROM Checkouts
                    WHERE CheckedIN IS NULL OR ConditionIn = 6";

                var checkedOutIds = new HashSet<int>();
                using (OleDbCommand cmd = new OleDbCommand(checkedOutQuery, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedOutIds.Add(reader.GetInt32(0));
                    }
                }

                // 3. Build list of available tools within skill level
                foreach (var kvp in allTools)
                {
                    if (!checkedOutIds.Contains(kvp.Key) && kvp.Value.Item2 <= employeeSkillLevel)
                    {
                        availableTools.Add(new ToolInfo
                        {
                            EquipmentID = kvp.Key,
                            EquipmentName = kvp.Value.Item1
                        });
                    }
                }
            }
            return availableTools;
        }


        /// <summary>
        /// Gets the number of tools currently checked out by the given employee.
        /// </summary>
        public int GetCurrentlyCheckedOutToolsCount(int employeeId)
        {
            using var conn = new OleDbConnection(_connectionString);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = Data.EmployeeQueries.CurrentlyCheckedOutToolCount;
            cmd.Parameters.AddWithValue("?", employeeId);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<ToolInfo> GetCheckedOutToolsByUser(int employeeId)
        {
            var tools = new List<ToolInfo>();

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT t.EquipmentID, t.EquipmentName
                    FROM Tools t
                    INNER JOIN Checkouts c ON t.EquipmentID = c.EquipmentID
                    WHERE c.EmployeeID = ? AND (c.ConditionIn IS NULL OR c.ConditionIn = 6)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", employeeId);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tools.Add(new ToolInfo
                            {
                                EquipmentID = reader.GetInt32(0),
                                EquipmentName = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return tools;

        }

    }

}