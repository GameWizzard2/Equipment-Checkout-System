using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class ReportQueries
    {
        public static readonly string OverdueCheckouts = @"
            SELECT c.EmployeeID, e.FirstName, e.LastName, t.EquipmentID, t.EquipmentName, c.CheckedOut, c.ReturnBy
            FROM ((Checkouts AS c
            INNER JOIN EmployeesList AS e ON c.EmployeeID = e.EmployeeID)
            INNER JOIN Tools AS t ON c.EquipmentID = t.EquipmentID)
            WHERE c.CheckedIN IS NULL AND c.ReturnBy < Date()";

        public static readonly string ToolUsageSummary = @"
            SELECT t.EquipmentName, COUNT(c.CheckoutID) AS TimesUsed
            FROM Tools t
            LEFT JOIN Checkouts c ON t.EquipmentID = c.EquipmentID
            GROUP BY t.EquipmentName";

        public static string ToolsCurrentlyCheckedOut = @"
           SELECT 
                T.EquipmentID,
                T.EquipmentName,
                E.FirstName & ' ' & E.LastName AS EmployeeName,
                C.CheckedOut,
                C.ReturnBy
            FROM 
                ((Checkouts AS C
                INNER JOIN Tools AS T ON C.EquipmentID = T.EquipmentID)
                INNER JOIN EmployeesList AS E ON C.EmployeeID = E.EmployeeID)
            WHERE 
                C.ReturnedBy IS NULL;
            ";

    }
}
