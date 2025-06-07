using Equipment_Checkout_System.Models;
using Equipment_Checkout_System.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Equipment_Checkout_System.Forms
{
    public partial class EmployeeForm : Form
    {
        private Employee currentUser;
        private string _connectionString;
        private CheckToolAvailibility _toolAvailabilityService;


        public EmployeeForm()
        {
            InitializeComponent();
            currentUser = SessionManager.CurrentUser;
            _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ECSCEIS400.accdb";
            _toolAvailabilityService = new CheckToolAvailibility(_connectionString);
        }

        // checkoutButton Here
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableTools.SelectedItem is ToolInfo selectedTool)
            {
                int employeeId = currentUser.EmployeeID;
                int equipmentId = selectedTool.EquipmentID;
                DateTime checkedOut = DateTime.Today;
                DateTime returnBy = checkedOut.AddDays(1); 

                var checkoutService = new CheckoutService(_connectionString); // Make sure connection string is accessible
                checkoutService.CheckOutTool(employeeId, equipmentId, checkedOut, returnBy, "New");

                MessageBox.Show($"{selectedTool.EquipmentName} checked out successfully!", "Success");

                RefreshAvailableToolList();
            }
            else
            {
                MessageBox.Show("Please select a tool to check out.");
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"{currentUser.FirstName} {currentUser.LastName}";

            // List available tools to checkout
            RefreshAvailableToolList();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void statusStripUser_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

        private void RefreshAvailableToolList()
        {
                listBoxAvailableTools.Items.Clear();
            List<ToolInfo> availableTools = _toolAvailabilityService.GetAvailableTools();
            listBoxAvailableTools.Items.Clear();
            foreach (ToolInfo tool in availableTools)
            {
                listBoxAvailableTools.Items.Add(tool);
            }
        }
    }
}
