using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Models
{
    public class ToolInfo
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }

        public override string ToString()
        {
            return $"{EquipmentName} (ID: {EquipmentID})";
        }
    }
}
