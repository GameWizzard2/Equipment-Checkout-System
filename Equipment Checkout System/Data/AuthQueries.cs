using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class AuthQueries
    {
        public static readonly string LoginQuery = @"
            SELECT *FROM EmployeesList
            WHERE UserName = ? AND EmployeePassword = ?";
    }

}
