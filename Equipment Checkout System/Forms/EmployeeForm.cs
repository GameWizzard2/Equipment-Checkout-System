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

using Equipment_Checkout_System.Services;

namespace Equipment_Checkout_System.Forms
{
    public partial class EmployeeForm : Form
    {
        private Employee currentUser;
        private CheckToolAvailibility _toolAvailabilityService;


        public EmployeeForm()
        {
            InitializeComponent();
            currentUser = SessionManager.CurrentUser;
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ECSCEIS400.accdb";
            _toolAvailabilityService = new CheckToolAvailibility(connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"{currentUser.FirstName} {currentUser.LastName}";

            // List available tools to checkout
            List<int> availableToolIds = _toolAvailabilityService.GetAvailableToolIds();

            listBoxAvailableTools.Items.Clear();
            foreach (int id in availableToolIds)
            {
                listBoxAvailableTools.Items.Add($"Tool ID: {id}");
            }
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
    }
}
