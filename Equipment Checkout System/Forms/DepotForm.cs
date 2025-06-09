using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Equipment_Checkout_System.Data;

namespace Equipment_Checkout_System.Forms;

public partial class DepotForm : Form
{
    private readonly string _connectionString = AppConfig.ConnectionString;

    public DepotForm()
    {
        InitializeComponent();

    }


    private void DepotForm_Load(object sender, EventArgs e)
    {
        // Load skill Selection for Tool Additions
        cmbSkillRequired.Items.AddRange(new object[] { 1, 2, 3, 4 });
        cmbSkillRequired.SelectedIndex = 0; // default to skill level 1
    }

    private void buttonAddTool_Click(object sender, EventArgs e)
    {
        string toolName = txtToolName.Text.Trim();

        // Get skillRequired from ComboBox
        if (cmbSkillRequired.SelectedItem == null)
        {
            MessageBox.Show("Please select a skill level.");
            return;
        }

        int skillRequired = Convert.ToInt32(cmbSkillRequired.SelectedItem);
        decimal toolPrice = numToolPrice.Value;

        if (string.IsNullOrWhiteSpace(toolName))
        {
            MessageBox.Show("Tool name is required.");
            return;
        }

        using (var conn = new OleDbConnection(_connectionString))
        {
            conn.Open();
            string insertQuery = "INSERT INTO Tools(EquipmentName, Status, EquipmentPrice, SkillRequired) VALUES(?, 'New', ?, ?)";

            using (var cmd = new OleDbCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", toolName);
                cmd.Parameters.AddWithValue("?", toolPrice);
                cmd.Parameters.AddWithValue("?", skillRequired);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Tool added successfully!");
        }
    }

    private void cmbSkillRequired_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
