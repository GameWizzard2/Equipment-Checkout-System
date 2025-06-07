using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Services
{
    public static class SessionManager
    {
        public static Employee CurrentUser { get; set; }
    }
}
