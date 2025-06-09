using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class AppConfig
    {
        public static readonly string ConnectionString =
           "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ECSCEIS400.accdb";
    }
}
