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

        // Load skill level selecyion for Employees
        cmbSkillLevelSelection.Items.AddRange(new object[] { 1, 2, 3, 4 });
        cmbSkillLevelSelection.SelectedIndex = 0;

        // Load Employee Role Selection
        cmbRoleSelection.Items.AddRange(new object[] { "Employee", "Supervisor", "DepotEmployee", "Admin" });
        cmbRoleSelection.SelectedIndex = 0;
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

    private void buttonAddEmployee_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text.Trim();
        string lastName = txtLastName.Text.Trim();
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();
        int skillLevel;
        string role = cmbRoleSelection.SelectedItem?.ToString();

        // Validate inputs
        if (string.IsNullOrWhiteSpace(firstName) ||
            string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(password) ||
            cmbSkillLevelSelection.SelectedItem == null ||
            cmbRoleSelection.SelectedItem == null)
        {
            MessageBox.Show("Please fill in all required fields.");
            return;
        }

        skillLevel = Convert.ToInt32(cmbSkillLevelSelection.SelectedItem);

        try
        {
            using (var conn = new OleDbConnection(AppConfig.ConnectionString))
            {
                conn.Open();

                // Optional: Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM EmployeesList WHERE UserName = ?";
                using (var checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("?", username);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Choose another one.");
                        return;
                    }
                }

                // Insert new employee
                string insertQuery = @"
                INSERT INTO EmployeesList 
                (FirstName, LastName, UserName, EmployeePassword, EmployeeSkillLevel, Role)
                VALUES (?, ?, ?, ?, ?, ?)";

                using (var cmd = new OleDbCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", firstName);
                    cmd.Parameters.AddWithValue("?", lastName);
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", password);
                    cmd.Parameters.AddWithValue("?", skillLevel);
                    cmd.Parameters.AddWithValue("?", role);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee added successfully!");
            }

            // Clear form
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbSkillLevelSelection.SelectedIndex = 0;
            cmbRoleSelection.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
