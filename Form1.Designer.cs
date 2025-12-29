namespace PROJ3
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.CatererLabel = new System.Windows.Forms.Label();
            this.ContractYrsLabel = new System.Windows.Forms.Label();
            this.BusinessLabel = new System.Windows.Forms.Label();
            this.ContractPriLabel = new System.Windows.Forms.Label();
            this.ContractPriOutput = new System.Windows.Forms.Label();
            this.CatererComboBox = new System.Windows.Forms.ComboBox();
            this.BusinessComboBox = new System.Windows.Forms.ComboBox();
            this.ContractYrsTextbox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(126, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Catering Contract Calculator";
            // 
            // CatererLabel
            // 
            this.CatererLabel.AutoSize = true;
            this.CatererLabel.Location = new System.Drawing.Point(52, 53);
            this.CatererLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CatererLabel.Name = "CatererLabel";
            this.CatererLabel.Size = new System.Drawing.Size(44, 13);
            this.CatererLabel.TabIndex = 1;
            this.CatererLabel.Text = "Caterer:";
            // 
            // ContractYrsLabel
            // 
            this.ContractYrsLabel.AutoSize = true;
            this.ContractYrsLabel.Location = new System.Drawing.Point(52, 107);
            this.ContractYrsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractYrsLabel.Name = "ContractYrsLabel";
            this.ContractYrsLabel.Size = new System.Drawing.Size(80, 13);
            this.ContractYrsLabel.TabIndex = 2;
            this.ContractYrsLabel.Text = "Contract Years:";
            // 
            // BusinessLabel
            // 
            this.BusinessLabel.AutoSize = true;
            this.BusinessLabel.Location = new System.Drawing.Point(52, 77);
            this.BusinessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BusinessLabel.Name = "BusinessLabel";
            this.BusinessLabel.Size = new System.Drawing.Size(52, 13);
            this.BusinessLabel.TabIndex = 3;
            this.BusinessLabel.Text = "Business:";
            // 
            // ContractPriLabel
            // 
            this.ContractPriLabel.AutoSize = true;
            this.ContractPriLabel.Location = new System.Drawing.Point(70, 184);
            this.ContractPriLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractPriLabel.Name = "ContractPriLabel";
            this.ContractPriLabel.Size = new System.Drawing.Size(77, 13);
            this.ContractPriLabel.TabIndex = 4;
            this.ContractPriLabel.Text = "Contract Price:";
            // 
            // ContractPriOutput
            // 
            this.ContractPriOutput.AutoSize = true;
            this.ContractPriOutput.Location = new System.Drawing.Point(239, 184);
            this.ContractPriOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractPriOutput.Name = "ContractPriOutput";
            this.ContractPriOutput.Size = new System.Drawing.Size(46, 13);
            this.ContractPriOutput.TabIndex = 5;
            this.ContractPriOutput.Text = "             ";
            // 
            // CatererComboBox
            // 
            this.CatererComboBox.FormattingEnabled = true;
            this.CatererComboBox.Location = new System.Drawing.Point(234, 48);
            this.CatererComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CatererComboBox.Name = "CatererComboBox";
            this.CatererComboBox.Size = new System.Drawing.Size(100, 21);
            this.CatererComboBox.TabIndex = 6;
            this.CatererComboBox.SelectedIndexChanged += new System.EventHandler(this.CatererComboBox_SelectedIndexChanged);
            // 
            // BusinessComboBox
            // 
            this.BusinessComboBox.FormattingEnabled = true;
            this.BusinessComboBox.Location = new System.Drawing.Point(234, 73);
            this.BusinessComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BusinessComboBox.Name = "BusinessComboBox";
            this.BusinessComboBox.Size = new System.Drawing.Size(100, 21);
            this.BusinessComboBox.TabIndex = 7;
            // 
            // ContractYrsTextbox
            // 
            this.ContractYrsTextbox.Location = new System.Drawing.Point(234, 107);
            this.ContractYrsTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractYrsTextbox.Name = "ContractYrsTextbox";
            this.ContractYrsTextbox.Size = new System.Drawing.Size(56, 20);
            this.ContractYrsTextbox.TabIndex = 8;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(150, 145);
            this.CalcBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(84, 35);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ContractYrsTextbox);
            this.Controls.Add(this.BusinessComboBox);
            this.Controls.Add(this.CatererComboBox);
            this.Controls.Add(this.ContractPriOutput);
            this.Controls.Add(this.ContractPriLabel);
            this.Controls.Add(this.BusinessLabel);
            this.Controls.Add(this.ContractYrsLabel);
            this.Controls.Add(this.CatererLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label CatererLabel;
        private System.Windows.Forms.Label ContractYrsLabel;
        private System.Windows.Forms.Label BusinessLabel;
        private System.Windows.Forms.Label ContractPriLabel;
        private System.Windows.Forms.Label ContractPriOutput;
        private System.Windows.Forms.ComboBox CatererComboBox;
        private System.Windows.Forms.ComboBox BusinessComboBox;
        private System.Windows.Forms.TextBox ContractYrsTextbox;
        private System.Windows.Forms.Button CalcBtn;
    }
}

