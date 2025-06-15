using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Equipment_Checkout_System.Data
{
    public static class EmployeeQueries

    {
        /// <summary>
        /// SQL query to count the number of tools currently checked out by a specific employee.
        /// </summary>
        /// <remarks>
        /// Uses the ? parameter to identify the employee ID and counts only records where CheckedOut is NULL.
        /// </remarks>
        public static readonly string CurrentlyCheckedOutToolCount = @"
            SELECT COUNT(*)
                FROM Checkouts 
                WHERE EmployeeID = ? 
                AND CheckedIN is NULL";

    }
}
