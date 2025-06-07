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

        public EmployeeForm()
        {
            InitializeComponent();
            currentUser = SessionManager.CurrentUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"{currentUser.FirstName} {currentUser.LastName}";
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
