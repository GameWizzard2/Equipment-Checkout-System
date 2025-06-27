using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipment_Checkout_System.Data;
using Equipment_Checkout_System.Services;

namespace Equipment_Checkout_System.Forms
{
    public partial class AdminForm : Form
    {
        private ReportCreatorService reportService;

        public AdminForm()
        {
            InitializeComponent();
            reportService = new ReportCreatorService();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonOverdueReport_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = reportService.RunQuery(ReportQueries.OverdueCheckouts);
        }

        private void buttonCheckedOutTools_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = reportService.RunQuery(ReportQueries.ToolsCurrentlyCheckedOut);
        }
    }
}
