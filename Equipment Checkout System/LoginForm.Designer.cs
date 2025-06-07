namespace Equipment_Checkout_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(333, 288);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Button1_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(354, 107);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(94, 25);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "UserName";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            labelUserName.Click += label1_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(354, 193);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            labelPassword.Click += label2_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(333, 221);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(333, 135);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(150, 31);
            textBoxUserName.TabIndex = 4;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(LoginButton);
            Name = "LoginForm";
            Text = "ECS Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
    }
}
