namespace WinFormPRJ
{
    partial class Product_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_order));
            textBoxForProductName = new TextBox();
            textBoxForProductPrice = new TextBox();
            textBoxForProductDescription = new TextBox();
            ProductNameLabel = new Label();
            ProductPriceLabel = new Label();
            ProductQualityLabel = new Label();
            ProdcutDescriptionLabel = new Label();
            numericUpDownQuality = new NumericUpDown();
            SaveProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuality).BeginInit();
            SuspendLayout();
            // 
            // textBoxForProductName
            // 
            textBoxForProductName.Location = new Point(119, 45);
            textBoxForProductName.Margin = new Padding(3, 4, 3, 4);
            textBoxForProductName.Name = "textBoxForProductName";
            textBoxForProductName.Size = new Size(251, 27);
            textBoxForProductName.TabIndex = 0;
            // 
            // textBoxForProductPrice
            // 
            textBoxForProductPrice.Location = new Point(119, 84);
            textBoxForProductPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxForProductPrice.Name = "textBoxForProductPrice";
            textBoxForProductPrice.Size = new Size(251, 27);
            textBoxForProductPrice.TabIndex = 0;
            // 
            // textBoxForProductDescription
            // 
            textBoxForProductDescription.Location = new Point(119, 161);
            textBoxForProductDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxForProductDescription.Multiline = true;
            textBoxForProductDescription.Name = "textBoxForProductDescription";
            textBoxForProductDescription.Size = new Size(251, 176);
            textBoxForProductDescription.TabIndex = 0;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(61, 48);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(52, 20);
            ProductNameLabel.TabIndex = 1;
            ProductNameLabel.Text = "Name:";
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Location = new Point(69, 88);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(44, 20);
            ProductPriceLabel.TabIndex = 1;
            ProductPriceLabel.Text = "Price:";
            // 
            // ProductQualityLabel
            // 
            ProductQualityLabel.AutoSize = true;
            ProductQualityLabel.Location = new Point(45, 126);
            ProductQualityLabel.Name = "ProductQualityLabel";
            ProductQualityLabel.Size = new Size(68, 20);
            ProductQualityLabel.TabIndex = 1;
            ProductQualityLabel.Text = "Quantity:";
            // 
            // ProdcutDescriptionLabel
            // 
            ProdcutDescriptionLabel.AutoSize = true;
            ProdcutDescriptionLabel.Location = new Point(25, 164);
            ProdcutDescriptionLabel.Name = "ProdcutDescriptionLabel";
            ProdcutDescriptionLabel.Size = new Size(88, 20);
            ProdcutDescriptionLabel.TabIndex = 1;
            ProdcutDescriptionLabel.Text = "Description:";
            // 
            // numericUpDownQuality
            // 
            numericUpDownQuality.Location = new Point(119, 124);
            numericUpDownQuality.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuality.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuality.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuality.Name = "numericUpDownQuality";
            numericUpDownQuality.Size = new Size(251, 27);
            numericUpDownQuality.TabIndex = 2;
            numericUpDownQuality.TextAlign = HorizontalAlignment.Right;
            numericUpDownQuality.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SaveProductButton
            // 
            SaveProductButton.BackColor = Color.SteelBlue;
            SaveProductButton.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveProductButton.ForeColor = SystemColors.Control;
            SaveProductButton.Location = new Point(281, 373);
            SaveProductButton.Margin = new Padding(2, 3, 2, 3);
            SaveProductButton.Name = "SaveProductButton";
            SaveProductButton.Size = new Size(89, 35);
            SaveProductButton.TabIndex = 4;
            SaveProductButton.Text = "SAVE";
            SaveProductButton.UseVisualStyleBackColor = false;
            SaveProductButton.Click += SaveProductButton_Click;
            // 
            // Product_order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 445);
            Controls.Add(SaveProductButton);
            Controls.Add(numericUpDownQuality);
            Controls.Add(ProdcutDescriptionLabel);
            Controls.Add(ProductQualityLabel);
            Controls.Add(ProductPriceLabel);
            Controls.Add(ProductNameLabel);
            Controls.Add(textBoxForProductDescription);
            Controls.Add(textBoxForProductPrice);
            Controls.Add(textBoxForProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Product_order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxForProductName;
        private TextBox textBoxForProductPrice;
        private TextBox textBoxForProductDescription;
        private Label ProductNameLabel;
        private Label ProductPriceLabel;
        private Label ProductQualityLabel;
        private Label ProdcutDescriptionLabel;
        private NumericUpDown numericUpDownQuality;
        private Button SaveProductButton;
    }
}