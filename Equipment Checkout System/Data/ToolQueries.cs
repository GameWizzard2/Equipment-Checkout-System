using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System.Data
{
    public static class ToolQueries
    {
        public static readonly string InsertTool = @"
            INSERT INTO Tools(EquipmentName, Status, EquipmentPrice, SkillRequired) 
            VALUES(?, 'New', ?, ?)";
    }


}
