namespace WinFormPRJ
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.DONEbutton = new System.Windows.Forms.Button();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.PastextBox = new System.Windows.Forms.TextBox();
            this.RePastextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasLabel = new System.Windows.Forms.Label();
            this.RePasLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // DONEbutton
            // 
            this.DONEbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.DONEbutton.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DONEbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.DONEbutton.Location = new System.Drawing.Point(141, 177);
            this.DONEbutton.Margin = new System.Windows.Forms.Padding(2);
            this.DONEbutton.Name = "DONEbutton";
            this.DONEbutton.Size = new System.Drawing.Size(78, 26);
            this.DONEbutton.TabIndex = 0;
            this.DONEbutton.Text = "DONE";
            this.DONEbutton.UseVisualStyleBackColor = false;
            this.DONEbutton.Click += new System.EventHandler(this.DONEbutton_Click);
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(113, 30);
            this.LogintextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(106, 23);
            this.LogintextBox.TabIndex = 1;
            // 
            // PastextBox
            // 
            this.PastextBox.Location = new System.Drawing.Point(113, 58);
            this.PastextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PastextBox.Name = "PastextBox";
            this.PastextBox.Size = new System.Drawing.Size(106, 23);
            this.PastextBox.TabIndex = 1;
            // 
            // RePastextBox
            // 
            this.RePastextBox.Location = new System.Drawing.Point(113, 87);
            this.RePastextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RePastextBox.Name = "RePastextBox";
            this.RePastextBox.Size = new System.Drawing.Size(106, 23);
            this.RePastextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(15, 34);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(40, 15);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login:";
            // 
            // PasLabel
            // 
            this.PasLabel.AutoSize = true;
            this.PasLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasLabel.Location = new System.Drawing.Point(15, 62);
            this.PasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasLabel.Name = "PasLabel";
            this.PasLabel.Size = new System.Drawing.Size(62, 15);
            this.PasLabel.TabIndex = 2;
            this.PasLabel.Text = "Password:";
            // 
            // RePasLabel
            // 
            this.RePasLabel.AutoSize = true;
            this.RePasLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RePasLabel.Location = new System.Drawing.Point(15, 91);
            this.RePasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RePasLabel.Name = "RePasLabel";
            this.RePasLabel.Size = new System.Drawing.Size(77, 15);
            this.RePasLabel.TabIndex = 2;
            this.RePasLabel.Text = "RePassword:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(113, 114);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(106, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(113, 141);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(106, 23);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(15, 117);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(15, 144);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(60, 15);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname:";
            // 
            // toolTip1
            // 
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 214);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RePasLabel);
            this.Controls.Add(this.PasLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RePastextBox);
            this.Controls.Add(this.PastextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.DONEbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DONEbutton;
        private TextBox LogintextBox;
        private TextBox PastextBox;
        private TextBox RePastextBox;
        private Label LoginLabel;
        private Label PasLabel;
        private Label RePasLabel;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private Label NameLabel;
        private Label SurnameLabel;
        private ToolTip toolTip1;
    }
}