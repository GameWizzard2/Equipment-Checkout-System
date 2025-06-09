using Equipment_Checkout_System.Forms;
using Equipment_Checkout_System.Models;
using Equipment_Checkout_System.Services;

namespace Equipment_Checkout_System

{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string inputUserName = textBoxUserName.Text.Trim();
            string inputPassword = textBoxPassword.Text.Trim();

            LoginService loginService = new LoginService();
            Employee user = loginService.TryLogin(inputUserName, inputPassword);

            if (user.Success)
            {
                SessionManager.CurrentUser = user;
                MessageBox.Show($"Welcome, {SessionManager.CurrentUser.FirstName} {SessionManager.CurrentUser.LastName} ({SessionManager.CurrentUser.Role})!", "Login Successful");

                this.Hide();  // hide login screen

                switch (SessionManager.CurrentUser.Role.ToLower())
                {
                    case "admin":
                        new AdminForm().Show();
                        break;

                    case "supervisor":
                        new SupervisorForm().Show();
                        break;

                    case "depotemployee":
                        new DepotForm().Show();
                        break;

                    case "employee":
                        new EmployeeForm().Show();
                        break;

                    default:
                        MessageBox.Show($"Role {SessionManager.CurrentUser.Role.ToLower()} not recognized. Contact your administrator.");
                        this.Show();  // show login again if needed
                        break;
                }
            }
            else
            {
                MessageBox.Show(user.ErrorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
