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
            SuspendLayout();
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(128, 100);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(112, 34);
            buttonCheckout.TabIndex = 0;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += button1_Click;
            // 
            // buttonCheckin
            // 
            buttonCheckin.Location = new Point(128, 140);
            buttonCheckin.Name = "buttonCheckin";
            buttonCheckin.Size = new Size(112, 34);
            buttonCheckin.TabIndex = 1;
            buttonCheckin.Text = "Checkin";
            buttonCheckin.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCheckin);
            Controls.Add(buttonCheckout);
            Name = "EmployeeForm";
            Text = "Employee";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCheckout;
        private Button buttonCheckin;
    }
}