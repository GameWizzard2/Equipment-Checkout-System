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
            lblCurrentNumberofToolsCheckedOut = new Label();
            statusStripUser = new StatusStrip();
            labelCheckedOutTools = new Label();
            listBoxAvailableTools = new ListBox();
            listBoxCheckedOutTools = new ListBox();
            lblUserName = new Label();
            SuspendLayout();
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(502, 294);
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
            buttonCheckin.Click += buttonCheckin_Click;
            // 
            // lblCurrentNumberofToolsCheckedOut
            // 
            lblCurrentNumberofToolsCheckedOut.Location = new Point(21, 61);
            lblCurrentNumberofToolsCheckedOut.Name = "lblCurrentNumberofToolsCheckedOut";
            lblCurrentNumberofToolsCheckedOut.Size = new Size(297, 66);
            lblCurrentNumberofToolsCheckedOut.TabIndex = 2;
            lblCurrentNumberofToolsCheckedOut.Text = "Label Set";
            lblCurrentNumberofToolsCheckedOut.TextAlign = ContentAlignment.TopCenter;
            lblCurrentNumberofToolsCheckedOut.Click += labelUser_Click;
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
            // labelCheckedOutTools
            // 
            labelCheckedOutTools.AutoSize = true;
            labelCheckedOutTools.Location = new Point(456, 102);
            labelCheckedOutTools.Name = "labelCheckedOutTools";
            labelCheckedOutTools.Size = new Size(209, 25);
            labelCheckedOutTools.TabIndex = 5;
            labelCheckedOutTools.Text = "Select Tool to Check Out:";
            labelCheckedOutTools.Click += labelCheckedOutTools_Click;
            // 
            // listBoxAvailableTools
            // 
            listBoxAvailableTools.FormattingEnabled = true;
            listBoxAvailableTools.ItemHeight = 25;
            listBoxAvailableTools.Location = new Point(470, 133);
            listBoxAvailableTools.Name = "listBoxAvailableTools";
            listBoxAvailableTools.Size = new Size(180, 129);
            listBoxAvailableTools.TabIndex = 7;
            // 
            // listBoxCheckedOutTools
            // 
            listBoxCheckedOutTools.FormattingEnabled = true;
            listBoxCheckedOutTools.ItemHeight = 25;
            listBoxCheckedOutTools.Location = new Point(82, 133);
            listBoxCheckedOutTools.Name = "listBoxCheckedOutTools";
            listBoxCheckedOutTools.Size = new Size(180, 129);
            listBoxCheckedOutTools.TabIndex = 8;
            listBoxCheckedOutTools.SelectedIndexChanged += listBoxCheckedOutTools_SelectedIndexChanged;
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(12, 28);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(309, 33);
            lblUserName.TabIndex = 9;
            lblUserName.Text = "label3";
            lblUserName.TextAlign = ContentAlignment.TopCenter;
            lblUserName.Click += lblUserName_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUserName);
            Controls.Add(listBoxCheckedOutTools);
            Controls.Add(listBoxAvailableTools);
            Controls.Add(labelCheckedOutTools);
            Controls.Add(statusStripUser);
            Controls.Add(lblCurrentNumberofToolsCheckedOut);
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
        private Label lblCurrentNumberofToolsCheckedOut;
        private StatusStrip statusStripUser;
        private Label labelCheckedOutTools;
        private ListBox listBoxAvailableTools;
        private ListBox listBoxCheckedOutTools;
        private Label lblUserName;
    }
}