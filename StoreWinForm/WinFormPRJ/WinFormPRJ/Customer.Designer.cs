namespace WinFormPRJ
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.NameCustTextBox = new System.Windows.Forms.TextBox();
            this.NameCustomerLabel = new System.Windows.Forms.Label();
            this.SurnameCustTextBox = new System.Windows.Forms.TextBox();
            this.SurnameCustomerLabel = new System.Windows.Forms.Label();
            this.EmailCustTextBox = new System.Windows.Forms.TextBox();
            this.EmailCustomerLabel = new System.Windows.Forms.Label();
            this.PhoneCustomerLabel = new System.Windows.Forms.Label();
            this.AdressCustomerLabel = new System.Windows.Forms.Label();
            this.AdressCustTextBox = new System.Windows.Forms.TextBox();
            this.SaveCustButton = new System.Windows.Forms.Button();
            this.PhoneCustTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NameCustTextBox
            // 
            this.NameCustTextBox.Location = new System.Drawing.Point(110, 42);
            this.NameCustTextBox.Name = "NameCustTextBox";
            this.NameCustTextBox.Size = new System.Drawing.Size(189, 23);
            this.NameCustTextBox.TabIndex = 0;
            // 
            // NameCustomerLabel
            // 
            this.NameCustomerLabel.AutoSize = true;
            this.NameCustomerLabel.Location = new System.Drawing.Point(27, 45);
            this.NameCustomerLabel.Name = "NameCustomerLabel";
            this.NameCustomerLabel.Size = new System.Drawing.Size(42, 15);
            this.NameCustomerLabel.TabIndex = 1;
            this.NameCustomerLabel.Text = "Name:";
            // 
            // SurnameCustTextBox
            // 
            this.SurnameCustTextBox.Location = new System.Drawing.Point(110, 71);
            this.SurnameCustTextBox.Name = "SurnameCustTextBox";
            this.SurnameCustTextBox.Size = new System.Drawing.Size(189, 23);
            this.SurnameCustTextBox.TabIndex = 0;
            // 
            // SurnameCustomerLabel
            // 
            this.SurnameCustomerLabel.AutoSize = true;
            this.SurnameCustomerLabel.Location = new System.Drawing.Point(27, 74);
            this.SurnameCustomerLabel.Name = "SurnameCustomerLabel";
            this.SurnameCustomerLabel.Size = new System.Drawing.Size(57, 15);
            this.SurnameCustomerLabel.TabIndex = 1;
            this.SurnameCustomerLabel.Text = "Surname:";
            // 
            // EmailCustTextBox
            // 
            this.EmailCustTextBox.Location = new System.Drawing.Point(110, 100);
            this.EmailCustTextBox.Name = "EmailCustTextBox";
            this.EmailCustTextBox.Size = new System.Drawing.Size(189, 23);
            this.EmailCustTextBox.TabIndex = 0;
            // 
            // EmailCustomerLabel
            // 
            this.EmailCustomerLabel.AutoSize = true;
            this.EmailCustomerLabel.Location = new System.Drawing.Point(27, 103);
            this.EmailCustomerLabel.Name = "EmailCustomerLabel";
            this.EmailCustomerLabel.Size = new System.Drawing.Size(39, 15);
            this.EmailCustomerLabel.TabIndex = 1;
            this.EmailCustomerLabel.Text = "Email:";
            // 
            // PhoneCustomerLabel
            // 
            this.PhoneCustomerLabel.AutoSize = true;
            this.PhoneCustomerLabel.Location = new System.Drawing.Point(27, 132);
            this.PhoneCustomerLabel.Name = "PhoneCustomerLabel";
            this.PhoneCustomerLabel.Size = new System.Drawing.Size(44, 15);
            this.PhoneCustomerLabel.TabIndex = 1;
            this.PhoneCustomerLabel.Text = "Phone:";
            // 
            // AdressCustomerLabel
            // 
            this.AdressCustomerLabel.AutoSize = true;
            this.AdressCustomerLabel.Location = new System.Drawing.Point(27, 161);
            this.AdressCustomerLabel.Name = "AdressCustomerLabel";
            this.AdressCustomerLabel.Size = new System.Drawing.Size(45, 15);
            this.AdressCustomerLabel.TabIndex = 1;
            this.AdressCustomerLabel.Text = "Adress:";
            // 
            // AdressCustTextBox
            // 
            this.AdressCustTextBox.Location = new System.Drawing.Point(110, 158);
            this.AdressCustTextBox.Multiline = true;
            this.AdressCustTextBox.Name = "AdressCustTextBox";
            this.AdressCustTextBox.Size = new System.Drawing.Size(189, 116);
            this.AdressCustTextBox.TabIndex = 0;
            // 
            // SaveCustButton
            // 
            this.SaveCustButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveCustButton.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveCustButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveCustButton.Location = new System.Drawing.Point(221, 290);
            this.SaveCustButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveCustButton.Name = "SaveCustButton";
            this.SaveCustButton.Size = new System.Drawing.Size(78, 25);
            this.SaveCustButton.TabIndex = 3;
            this.SaveCustButton.Text = "SAVE";
            this.SaveCustButton.UseVisualStyleBackColor = false;
            this.SaveCustButton.Click += new System.EventHandler(this.SaveCustButton_Click);
            // 
            // PhoneCustTextBox
            // 
            this.PhoneCustTextBox.Location = new System.Drawing.Point(110, 129);
            this.PhoneCustTextBox.Mask = "(+999)00-000-00-00";
            this.PhoneCustTextBox.Name = "PhoneCustTextBox";
            this.PhoneCustTextBox.Size = new System.Drawing.Size(189, 23);
            this.PhoneCustTextBox.TabIndex = 4;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 346);
            this.Controls.Add(this.PhoneCustTextBox);
            this.Controls.Add(this.SaveCustButton);
            this.Controls.Add(this.AdressCustomerLabel);
            this.Controls.Add(this.PhoneCustomerLabel);
            this.Controls.Add(this.EmailCustomerLabel);
            this.Controls.Add(this.SurnameCustomerLabel);
            this.Controls.Add(this.NameCustomerLabel);
            this.Controls.Add(this.AdressCustTextBox);
            this.Controls.Add(this.EmailCustTextBox);
            this.Controls.Add(this.SurnameCustTextBox);
            this.Controls.Add(this.NameCustTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameCustTextBox;
        private Label NameCustomerLabel;
        private TextBox SurnameCustTextBox;
        private Label SurnameCustomerLabel;
        private TextBox EmailCustTextBox;
        private Label EmailCustomerLabel;
        private Label PhoneCustomerLabel;
        private Label AdressCustomerLabel;
        private TextBox AdressCustTextBox;
        private Button SaveCustButton;
        private MaskedTextBox PhoneCustTextBox;
    }
}