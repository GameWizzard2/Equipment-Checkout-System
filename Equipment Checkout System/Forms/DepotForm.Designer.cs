namespace Equipment_Checkout_System.Forms
{
    partial class DepotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddTool = new Button();
            txtToolName = new TextBox();
            numToolPrice = new NumericUpDown();
            cmbSkillRequired = new ComboBox();
            labelToolName = new Label();
            labelSelectSkill = new Label();
            label3 = new Label();
            buttonAddEmployee = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            labelUserCreation = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRoleSelection = new ComboBox();
            cmbSkillLevelSelection = new ComboBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelUserName = new Label();
            labelPassword = new Label();
            labelEmployeeSkill = new Label();
            labelRole = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)numToolPrice).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddTool
            // 
            buttonAddTool.Location = new Point(169, 219);
            buttonAddTool.Name = "buttonAddTool";
            buttonAddTool.Size = new Size(158, 34);
            buttonAddTool.TabIndex = 0;
            buttonAddTool.Text = "AddTool";
            buttonAddTool.UseVisualStyleBackColor = true;
            buttonAddTool.Click += buttonAddTool_Click;
            // 
            // txtToolName
            // 
            txtToolName.Location = new Point(260, 69);
            txtToolName.Name = "txtToolName";
            txtToolName.Size = new Size(150, 31);
            txtToolName.TabIndex = 1;
            // 
            // numToolPrice
            // 
            numToolPrice.Location = new Point(260, 173);
            numToolPrice.Name = "numToolPrice";
            numToolPrice.Size = new Size(180, 31);
            numToolPrice.TabIndex = 2;
            // 
            // cmbSkillRequired
            // 
            cmbSkillRequired.FormattingEnabled = true;
            cmbSkillRequired.Location = new Point(260, 122);
            cmbSkillRequired.Name = "cmbSkillRequired";
            cmbSkillRequired.Size = new Size(182, 33);
            cmbSkillRequired.TabIndex = 3;
            cmbSkillRequired.SelectedIndexChanged += cmbSkillRequired_SelectedIndexChanged;
            // 
            // labelToolName
            // 
            labelToolName.AutoSize = true;
            labelToolName.Location = new Point(99, 69);
            labelToolName.Name = "labelToolName";
            labelToolName.Size = new Size(143, 25);
            labelToolName.TabIndex = 4;
            labelToolName.Text = "Type Tool Name:";
            labelToolName.Click += label1_Click;
            // 
            // labelSelectSkill
            // 
            labelSelectSkill.AutoSize = true;
            labelSelectSkill.Location = new Point(62, 122);
            labelSelectSkill.Name = "labelSelectSkill";
            labelSelectSkill.Size = new Size(180, 25);
            labelSelectSkill.TabIndex = 5;
            labelSelectSkill.Text = "Select Tool Skill Level:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 175);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 6;
            label3.Text = "Estimated Price of Tool:";
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(178, 270);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(154, 34);
            buttonAddEmployee.TabIndex = 7;
            buttonAddEmployee.Text = "Add Employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(159, 16);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(201, 31);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(159, 53);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 31);
            txtLastName.TabIndex = 9;
            // 
            // labelUserCreation
            // 
            labelUserCreation.AutoSize = true;
            labelUserCreation.Location = new Point(205, 90);
            labelUserCreation.Name = "labelUserCreation";
            labelUserCreation.Size = new Size(106, 25);
            labelUserCreation.TabIndex = 10;
            labelUserCreation.Text = "User Profile:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(159, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 31);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 31);
            txtPassword.TabIndex = 12;
            // 
            // cmbRoleSelection
            // 
            cmbRoleSelection.FormattingEnabled = true;
            cmbRoleSelection.Location = new Point(159, 231);
            cmbRoleSelection.Name = "cmbRoleSelection";
            cmbRoleSelection.Size = new Size(201, 33);
            cmbRoleSelection.TabIndex = 13;
            // 
            // cmbSkillLevelSelection
            // 
            cmbSkillLevelSelection.FormattingEnabled = true;
            cmbSkillLevelSelection.Location = new Point(159, 192);
            cmbSkillLevelSelection.Name = "cmbSkillLevelSelection";
            cmbSkillLevelSelection.Size = new Size(201, 33);
            cmbSkillLevelSelection.TabIndex = 14;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(49, 16);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(101, 25);
            labelFirstName.TabIndex = 15;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(40, 53);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(99, 25);
            labelLastName.TabIndex = 16;
            labelLastName.Text = "Last Name:";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(50, 121);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(103, 25);
            labelUserName.TabIndex = 17;
            labelUserName.Text = "User Name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(59, 161);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 25);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Password:";
            // 
            // labelEmployeeSkill
            // 
            labelEmployeeSkill.AutoSize = true;
            labelEmployeeSkill.Location = new Point(62, 195);
            labelEmployeeSkill.Name = "labelEmployeeSkill";
            labelEmployeeSkill.Size = new Size(91, 25);
            labelEmployeeSkill.TabIndex = 19;
            labelEmployeeSkill.Text = "Skill Level:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(27, 234);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(126, 25);
            labelRole.TabIndex = 20;
            labelRole.Text = "Role Selection:";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(2, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(517, 388);
            tabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numToolPrice);
            tabPage1.Controls.Add(buttonAddTool);
            tabPage1.Controls.Add(txtToolName);
            tabPage1.Controls.Add(cmbSkillRequired);
            tabPage1.Controls.Add(labelToolName);
            tabPage1.Controls.Add(labelSelectSkill);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(509, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelUserName);
            tabPage2.Controls.Add(labelRole);
            tabPage2.Controls.Add(buttonAddEmployee);
            tabPage2.Controls.Add(labelEmployeeSkill);
            tabPage2.Controls.Add(txtFirstName);
            tabPage2.Controls.Add(labelPassword);
            tabPage2.Controls.Add(txtLastName);
            tabPage2.Controls.Add(labelUserCreation);
            tabPage2.Controls.Add(labelLastName);
            tabPage2.Controls.Add(txtUsername);
            tabPage2.Controls.Add(labelFirstName);
            tabPage2.Controls.Add(txtPassword);
            tabPage2.Controls.Add(cmbSkillLevelSelection);
            tabPage2.Controls.Add(cmbRoleSelection);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(509, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Employee";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // DepotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 383);
            Controls.Add(tabControl);
            Name = "DepotForm";
            Text = "Depot Assistant";
            Load += DepotForm_Load;
            ((System.ComponentModel.ISupportInitialize)numToolPrice).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddTool;
        private TextBox txtToolName;
        private NumericUpDown numToolPrice;
        private ComboBox cmbSkillRequired;
        private Label labelToolName;
        private Label labelSelectSkill;
        private Label label3;
        private Button buttonAddEmployee;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label labelUserCreation;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRoleSelection;
        private ComboBox cmbSkillLevelSelection;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelUserName;
        private Label labelPassword;
        private Label labelEmployeeSkill;
        private Label labelRole;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}