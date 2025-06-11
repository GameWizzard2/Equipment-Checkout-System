using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class EmployeeQueries
    {
        // Check if username exist.
        public static readonly string CheckUsernameExists = @"
            SELECT COUNT(*) FROM EmployeesList WHERE UserName = ?";
     
        // Insert employee data into database.
        public static readonly string InsertEmployee = @"
            INSERT INTO EmployeesList 
            (FirstName, LastName, UserName, EmployeePassword, EmployeeSkillLevel, Role)
            VALUES (?, ?, ?, ?, ?, ?)";
    }

}