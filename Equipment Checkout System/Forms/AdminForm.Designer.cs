﻿namespace Equipment_Checkout_System.Forms
{
    partial class AdminForm
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
            buttonOverdueReport = new Button();
            dgvReport = new DataGridView();
            buttonCheckedOutTools = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // buttonOverdueReport
            // 
            buttonOverdueReport.Location = new Point(203, 268);
            buttonOverdueReport.Name = "buttonOverdueReport";
            buttonOverdueReport.Size = new Size(112, 58);
            buttonOverdueReport.TabIndex = 0;
            buttonOverdueReport.Text = "Overdue";
            buttonOverdueReport.UseVisualStyleBackColor = true;
            buttonOverdueReport.Click += buttonOverdueReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(203, 37);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(360, 225);
            dgvReport.TabIndex = 1;
            // 
            // buttonCheckedOutTools
            // 
            buttonCheckedOutTools.Location = new Point(321, 268);
            buttonCheckedOutTools.Name = "buttonCheckedOutTools";
            buttonCheckedOutTools.Size = new Size(112, 58);
            buttonCheckedOutTools.TabIndex = 2;
            buttonCheckedOutTools.Text = "Checked Out";
            buttonCheckedOutTools.UseVisualStyleBackColor = true;
            buttonCheckedOutTools.Click += buttonCheckedOutTools_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCheckedOutTools);
            Controls.Add(dgvReport);
            Controls.Add(buttonOverdueReport);
            Name = "AdminForm";
            Text = "Admin";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOverdueReport;
        private DataGridView dgvReport;
        private Button buttonCheckedOutTools;
    }
}