using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class AlertQueries

    {
        /// <summary>
        /// SQL query to retrieve overdue tools for a specific employee.
        /// </summary>
        /// <remarks>
        /// Uses the ? parameter for employee ID.
        /// Access’s Date() function returns current date without time.
        /// DateDiff('d', ...) calculates full days late.
        /// </remarks>
        public static readonly string LateToolAlert = @"
            SELECT 
                c.EquipmentID,
                t.EquipmentName,
                c.ReturnBy,
                DateDiff('d', c.ReturnBy, Date()) AS DaysLate
            FROM Checkouts AS c
            INNER JOIN Tools AS t
                ON c.EquipmentID = t.EquipmentID
            WHERE 
                c.EmployeeID = ?
                AND c.CheckedIN IS NULL
                AND c.ReturnBy < Date();";
    }
}
