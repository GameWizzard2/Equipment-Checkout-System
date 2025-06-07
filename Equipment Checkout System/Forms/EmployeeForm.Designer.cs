namespace Equipment_Checkout_System.Forms
{
    partial class EmployeeForm
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
            buttonCheckout = new Button();
            buttonCheckin = new Button();
            labelUser = new Label();
            statusStripUser = new StatusStrip();
            label2 = new Label();
            labelCheckedOutTools = new Label();
            label1 = new Label();
            listBoxAvailableTools = new ListBox();
            SuspendLayout();
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(526, 318);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(112, 34);
            buttonCheckout.TabIndex = 0;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += button1_Click;
            // 
            // buttonCheckin
            // 
            buttonCheckin.Location = new Point(111, 294);
            buttonCheckin.Name = "buttonCheckin";
            buttonCheckin.Size = new Size(112, 34);
            buttonCheckin.TabIndex = 1;
            buttonCheckin.Text = "Checkin";
            buttonCheckin.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(129, 77);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(59, 25);
            labelUser.TabIndex = 2;
            labelUser.Text = "label1";
            labelUser.Click += labelUser_Click;
            // 
            // statusStripUser
            // 
            statusStripUser.ImageScalingSize = new Size(24, 24);
            statusStripUser.Location = new Point(0, 428);
            statusStripUser.Name = "statusStripUser";
            statusStripUser.Size = new Size(800, 22);
            statusStripUser.TabIndex = 3;
            statusStripUser.Text = "statusStrip1";
            statusStripUser.ItemClicked += statusStripUser_ItemClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 26);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 4;
            label2.Text = "Current Tools Checked Out:";
            label2.Click += label1_Click;
            // 
            // labelCheckedOutTools
            // 
            labelCheckedOutTools.AutoSize = true;
            labelCheckedOutTools.Location = new Point(535, 77);
            labelCheckedOutTools.Name = "labelCheckedOutTools";
            labelCheckedOutTools.Size = new Size(59, 25);
            labelCheckedOutTools.TabIndex = 5;
            labelCheckedOutTools.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 6;
            label1.Text = "User:";
            // 
            // listBoxAvailableTools
            // 
            listBoxAvailableTools.FormattingEnabled = true;
            listBoxAvailableTools.ItemHeight = 25;
            listBoxAvailableTools.Location = new Point(494, 166);
            listBoxAvailableTools.Name = "listBoxAvailableTools";
            listBoxAvailableTools.Size = new Size(180, 129);
            listBoxAvailableTools.TabIndex = 7;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxAvailableTools);
            Controls.Add(label1);
            Controls.Add(labelCheckedOutTools);
            Controls.Add(label2);
            Controls.Add(statusStripUser);
            Controls.Add(labelUser);
            Controls.Add(buttonCheckin);
            Controls.Add(buttonCheckout);
            Name = "EmployeeForm";
            Text = "Employee";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCheckout;
        private Button buttonCheckin;
        private Label labelUser;
        private StatusStrip statusStripUser;
        private Label label2;
        private Label labelCheckedOutTools;
        private Label label1;
        private ListBox listBoxAvailableTools;
    }
}