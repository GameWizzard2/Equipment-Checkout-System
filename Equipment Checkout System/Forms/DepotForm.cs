
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
using Equipment_Checkout_System.Services;

namespace Equipment_Checkout_System.Forms;

// Form for managing tool and employee creation in the Depot
public partial class DepotForm : Form
{
    // Centralized database connection string
    private readonly string _connectionString = AppConfig.ConnectionString;
    private readonly ToolServices _toolService;
    private readonly EmployeeServices _employeeService;

    public DepotForm()
    {
        InitializeComponent();
        _toolService = new ToolServices(AppConfig.ConnectionString);
        _employeeService = new EmployeeServices(AppConfig.ConnectionString);
    }

    // Executes on form load
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

    // Adds tool to the database when button is clicked
    private void buttonAddTool_Click(object sender, EventArgs e)
    {
        string toolName = txtToolName.Text.Trim();
        if (string.IsNullOrWhiteSpace(toolName))
        {
            MessageBox.Show("Tool name is required.");
            return;
        }

        if (cmbSkillRequired.SelectedItem == null)
        {
            MessageBox.Show("Please select a skill level.");
            return;
        }

        int skillRequired = Convert.ToInt32(cmbSkillRequired.SelectedItem);
        decimal toolPrice = numToolPrice.Value;

        _toolService.AddTool(toolName, toolPrice, skillRequired);
        MessageBox.Show("Tool added successfully!");
    }

    private void cmbSkillRequired_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    // Adds a new employee to the database when button is clicked.
    private void buttonAddEmployee_Click(object sender, EventArgs e)
    {
        // Get user input from form.
        string firstName = txtFirstName.Text.Trim();
        string lastName = txtLastName.Text.Trim();
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();
        int skillLevel; // Skill level is handled by combo box
        string role = cmbRoleSelection.SelectedItem?.ToString();

        // Validate all field have been filled.
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
                if (_employeeService.UserNameExists(username)) 
                    {
                        MessageBox.Show("Username already exists. Choose another one.");
                        return;
                    }
                

                // Add new employee into database table.
                _employeeService.AddEmployee(firstName, lastName, username, password, skillLevel, role);
                MessageBox.Show("Employee added successfully!");
            

            // Clear form after submission is completed .
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
