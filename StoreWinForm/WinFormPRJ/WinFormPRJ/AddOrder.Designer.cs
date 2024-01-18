namespace WinFormPRJ
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.ClientNameComboBox = new System.Windows.Forms.ComboBox();
            this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityProducNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerForOrder = new System.Windows.Forms.DateTimePicker();
            this.labelofnameorder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityProducNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNameComboBox
            // 
            this.ClientNameComboBox.FormattingEnabled = true;
            this.ClientNameComboBox.Location = new System.Drawing.Point(118, 47);
            this.ClientNameComboBox.Name = "ClientNameComboBox";
            this.ClientNameComboBox.Size = new System.Drawing.Size(200, 23);
            this.ClientNameComboBox.TabIndex = 0;
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.Location = new System.Drawing.Point(118, 76);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(200, 23);
            this.ProductNameComboBox.TabIndex = 0;
            // 
            // QuantityProducNumericUpDown
            // 
            this.QuantityProducNumericUpDown.Location = new System.Drawing.Point(118, 105);
            this.QuantityProducNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityProducNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityProducNumericUpDown.Name = "QuantityProducNumericUpDown";
            this.QuantityProducNumericUpDown.Size = new System.Drawing.Size(200, 23);
            this.QuantityProducNumericUpDown.TabIndex = 1;
            this.QuantityProducNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QuantityProducNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerForOrder
            // 
            this.dateTimePickerForOrder.Location = new System.Drawing.Point(118, 134);
            this.dateTimePickerForOrder.Name = "dateTimePickerForOrder";
            this.dateTimePickerForOrder.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerForOrder.TabIndex = 2;
            // 
            // labelofnameorder
            // 
            this.labelofnameorder.AutoSize = true;
            this.labelofnameorder.Location = new System.Drawing.Point(66, 50);
            this.labelofnameorder.Name = "labelofnameorder";
            this.labelofnameorder.Size = new System.Drawing.Size(42, 15);
            this.labelofnameorder.TabIndex = 3;
            this.labelofnameorder.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrive time:";
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveProductButton.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveProductButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveProductButton.Location = new System.Drawing.Point(240, 174);
            this.SaveProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(78, 26);
            this.SaveProductButton.TabIndex = 5;
            this.SaveProductButton.Text = "SAVE";
            this.SaveProductButton.UseVisualStyleBackColor = false;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity:";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 238);
            this.Controls.Add(this.SaveProductButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelofnameorder);
            this.Controls.Add(this.dateTimePickerForOrder);
            this.Controls.Add(this.QuantityProducNumericUpDown);
            this.Controls.Add(this.ProductNameComboBox);
            this.Controls.Add(this.ClientNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityProducNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ClientNameComboBox;
        private ComboBox ProductNameComboBox;
        private NumericUpDown QuantityProducNumericUpDown;
        private DateTimePicker dateTimePickerForOrder;
        private Label labelofnameorder;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SaveProductButton;
        private Label label1;
        private Label label5;
    }
}