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
        private string _connectionString; // Database Connection string
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

            }
            else
            {
                MessageBox.Show("Please select a tool to check out.");
            }
            RefreshAvailableToolList();
            RefreshCheckedOutToolList();
            UpdateCheckedOutLabel();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lblCurrentNumberofToolsCheckedOut.Text = $"{currentUser.FirstName} {currentUser.LastName}";

            // List available tools to checkout
            RefreshAvailableToolList();
            RefreshCheckedOutToolList();
            UpdateCheckedOutLabel();
            setlblUserName();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void UpdateCheckedOutLabel()
        {
            int count = _toolAvailabilityService.GetCurrentlyCheckedOutToolsCount(currentUser.EmployeeID);
            lblCurrentNumberofToolsCheckedOut.Text =
                $"Tools Currently Checked Out ({count}):{Environment.NewLine}Select One To Return:";
        }

        private void setlblUserName()
        {
            lblUserName.Text = $"User: {currentUser.FirstName} {currentUser.LastName}";
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
            List<ToolInfo> availableTools = _toolAvailabilityService.GetAvailableTools(currentUser.SkillLevel);

            foreach (ToolInfo tool in availableTools)
            {
                listBoxAvailableTools.Items.Add(tool);
            }
        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {
            if (listBoxCheckedOutTools.SelectedItem is ToolInfo selectedTool)
            {
                var service = new CheckoutService(_connectionString);
                DateTime returnedOn = DateTime.Now;
                service.CheckInTool(selectedTool.EquipmentID, currentUser.EmployeeID, 1, returnedOn); //Fixme 1 represents the condition that the tool is in. replace with a dropdown list for user to select.

                MessageBox.Show($"Returned: {selectedTool.EquipmentName}");

            }
            else
            {
                MessageBox.Show("Select a tool to return.");
            }
            RefreshCheckedOutToolList();
            RefreshAvailableToolList();
            UpdateCheckedOutLabel();
        }

        private void RefreshCheckedOutToolList()
        {
            listBoxCheckedOutTools.Items.Clear();

            var checkedOutTools = _toolAvailabilityService.GetCheckedOutToolsByUser(currentUser.EmployeeID);

            foreach (var tool in checkedOutTools)
            {
                listBoxCheckedOutTools.Items.Add(tool); // ToolInfo.ToString() will display name
            }
        }


        private void listBoxCheckedOutTools_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCheckedOutTools_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
