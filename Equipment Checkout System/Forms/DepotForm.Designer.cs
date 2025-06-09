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
            ((System.ComponentModel.ISupportInitialize)numToolPrice).BeginInit();
            SuspendLayout();
            // 
            // buttonAddTool
            // 
            buttonAddTool.Location = new Point(370, 286);
            buttonAddTool.Name = "buttonAddTool";
            buttonAddTool.Size = new Size(112, 34);
            buttonAddTool.TabIndex = 0;
            buttonAddTool.Text = "AddTool";
            buttonAddTool.UseVisualStyleBackColor = true;
            buttonAddTool.Click += buttonAddTool_Click;
            // 
            // txtToolName
            // 
            txtToolName.Location = new Point(346, 125);
            txtToolName.Name = "txtToolName";
            txtToolName.Size = new Size(150, 31);
            txtToolName.TabIndex = 1;
            // 
            // numToolPrice
            // 
            numToolPrice.Location = new Point(346, 229);
            numToolPrice.Name = "numToolPrice";
            numToolPrice.Size = new Size(180, 31);
            numToolPrice.TabIndex = 2;
            // 
            // cmbSkillRequired
            // 
            cmbSkillRequired.FormattingEnabled = true;
            cmbSkillRequired.Location = new Point(346, 178);
            cmbSkillRequired.Name = "cmbSkillRequired";
            cmbSkillRequired.Size = new Size(182, 33);
            cmbSkillRequired.TabIndex = 3;
            cmbSkillRequired.SelectedIndexChanged += cmbSkillRequired_SelectedIndexChanged;
            // 
            // labelToolName
            // 
            labelToolName.AutoSize = true;
            labelToolName.Location = new Point(185, 125);
            labelToolName.Name = "labelToolName";
            labelToolName.Size = new Size(143, 25);
            labelToolName.TabIndex = 4;
            labelToolName.Text = "Type Tool Name:";
            labelToolName.Click += label1_Click;
            // 
            // labelSelectSkill
            // 
            labelSelectSkill.AutoSize = true;
            labelSelectSkill.Location = new Point(148, 178);
            labelSelectSkill.Name = "labelSelectSkill";
            labelSelectSkill.Size = new Size(180, 25);
            labelSelectSkill.TabIndex = 5;
            labelSelectSkill.Text = "Select Tool Skill Level:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 231);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 6;
            label3.Text = "Estimated Price of Tool:";
            // 
            // DepotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(labelSelectSkill);
            Controls.Add(labelToolName);
            Controls.Add(cmbSkillRequired);
            Controls.Add(numToolPrice);
            Controls.Add(txtToolName);
            Controls.Add(buttonAddTool);
            Name = "DepotForm";
            Text = "Depot Assistant";
            Load += DepotForm_Load;
            ((System.ComponentModel.ISupportInitialize)numToolPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddTool;
        private TextBox txtToolName;
        private NumericUpDown numToolPrice;
        private ComboBox cmbSkillRequired;
        private Label labelToolName;
        private Label labelSelectSkill;
        private Label label3;
    }
}