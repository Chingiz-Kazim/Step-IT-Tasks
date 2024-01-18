namespace WinFormPRJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            listViewProducts = new ListView();
            columnProductName = new ColumnHeader();
            columnProductPrice = new ColumnHeader();
            columnProductQuality = new ColumnHeader();
            columnProductDescription = new ColumnHeader();
            listViewClients = new ListView();
            columnName = new ColumnHeader();
            columnSurname = new ColumnHeader();
            columnEmail = new ColumnHeader();
            columnPhone = new ColumnHeader();
            columnAdress = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            clientToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            acceptToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem1 = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            listToolStripMenuItem2 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            closeAppToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            SignInButton = new Button();
            label2 = new Label();
            SignUpButton = new Button();
            label3 = new Label();
            viewButton = new Button();
            passwordTextBoxP1 = new TextBox();
            loginTextBoxP1 = new TextBox();
            panel3 = new Panel();
            listViewOrders = new ListView();
            columname = new ColumnHeader();
            columnproduct = new ColumnHeader();
            columnquality = new ColumnHeader();
            columnarriveDate = new ColumnHeader();
            Filterabel = new Label();
            FilterTextBox = new TextBox();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            closeAppToolStripMenuItem1 = new ToolStripMenuItem();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewProducts);
            panel2.Controls.Add(listViewClients);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(467, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 546);
            panel2.TabIndex = 0;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnProductName, columnProductPrice, columnProductQuality, columnProductDescription });
            listViewProducts.Dock = DockStyle.Fill;
            listViewProducts.FullRowSelect = true;
            listViewProducts.GridLines = true;
            listViewProducts.Location = new Point(0, 28);
            listViewProducts.Margin = new Padding(3, 4, 3, 4);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(433, 518);
            listViewProducts.TabIndex = 3;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            // 
            // columnProductName
            // 
            columnProductName.Text = "Name";
            columnProductName.Width = 120;
            // 
            // columnProductPrice
            // 
            columnProductPrice.Text = "Price";
            columnProductPrice.Width = 90;
            // 
            // columnProductQuality
            // 
            columnProductQuality.Text = "Quantity";
            columnProductQuality.Width = 90;
            // 
            // columnProductDescription
            // 
            columnProductDescription.Text = "Description";
            columnProductDescription.Width = 800;
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnName, columnSurname, columnEmail, columnPhone, columnAdress });
            listViewClients.Dock = DockStyle.Fill;
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(0, 28);
            listViewClients.Margin = new Padding(3, 4, 3, 4);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(433, 518);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 120;
            // 
            // columnSurname
            // 
            columnSurname.Text = "Surname";
            columnSurname.Width = 140;
            // 
            // columnEmail
            // 
            columnEmail.Text = "Email";
            columnEmail.Width = 150;
            // 
            // columnPhone
            // 
            columnPhone.Text = "Phone";
            columnPhone.Width = 140;
            // 
            // columnAdress
            // 
            columnAdress.Text = "Adress";
            columnAdress.Width = 500;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientToolStripMenuItem, orderToolStripMenuItem, productToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(433, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, listToolStripMenuItem });
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(61, 24);
            clientToolStripMenuItem.Text = "&Client";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(120, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(120, 26);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acceptToolStripMenuItem, listToolStripMenuItem1 });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "&Order";
            // 
            // acceptToolStripMenuItem
            // 
            acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            acceptToolStripMenuItem.Size = new Size(138, 26);
            acceptToolStripMenuItem.Text = "Accept";
            acceptToolStripMenuItem.Click += acceptToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem1
            // 
            listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            listToolStripMenuItem1.Size = new Size(138, 26);
            listToolStripMenuItem1.Text = "List";
            listToolStripMenuItem1.Click += listToolStripMenuItem1_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, listToolStripMenuItem2 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "&Product";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(120, 26);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // listToolStripMenuItem2
            // 
            listToolStripMenuItem2.Name = "listToolStripMenuItem2";
            listToolStripMenuItem2.Size = new Size(120, 26);
            listToolStripMenuItem2.Text = "List";
            listToolStripMenuItem2.Click += listToolStripMenuItem2_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, closeAppToolStripMenuItem });
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "&Log out";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(160, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // closeAppToolStripMenuItem
            // 
            closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            closeAppToolStripMenuItem.Size = new Size(160, 26);
            closeAppToolStripMenuItem.Text = "Close App";
            closeAppToolStripMenuItem.Click += closeAppToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(viewButton);
            panel1.Controls.Add(passwordTextBoxP1);
            panel1.Controls.Add(loginTextBoxP1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.MaximumSize = new Size(950, 950);
            panel1.MinimumSize = new Size(434, 546);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 950);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 239);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(473, 491);
            SignInButton.Margin = new Padding(3, 4, 3, 4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(171, 34);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "SIGN IN";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(287, 452);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(287, 491);
            SignUpButton.Margin = new Padding(3, 4, 3, 4);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(180, 34);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "SIGN UP";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(336, 408);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "LOGIN";
            // 
            // viewButton
            // 
            viewButton.Location = new Point(614, 456);
            viewButton.Margin = new Padding(3, 4, 3, 4);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(30, 27);
            viewButton.TabIndex = 4;
            viewButton.Text = "👁";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.MouseDown += viewButton_MouseDown;
            viewButton.MouseUp += viewButton_MouseUp;
            // 
            // passwordTextBoxP1
            // 
            passwordTextBoxP1.Location = new Point(415, 456);
            passwordTextBoxP1.Margin = new Padding(3, 4, 3, 4);
            passwordTextBoxP1.Name = "passwordTextBoxP1";
            passwordTextBoxP1.Size = new Size(193, 27);
            passwordTextBoxP1.TabIndex = 1;
            passwordTextBoxP1.UseSystemPasswordChar = true;
            // 
            // loginTextBoxP1
            // 
            loginTextBoxP1.Location = new Point(415, 412);
            loginTextBoxP1.Margin = new Padding(3, 4, 3, 4);
            loginTextBoxP1.Name = "loginTextBoxP1";
            loginTextBoxP1.Size = new Size(193, 27);
            loginTextBoxP1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(listViewOrders);
            panel3.Controls.Add(Filterabel);
            panel3.Controls.Add(FilterTextBox);
            panel3.Controls.Add(menuStrip2);
            panel3.Location = new Point(775, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 950);
            panel3.TabIndex = 2;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columname, columnproduct, columnquality, columnarriveDate });
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(0, 94);
            listViewOrders.Margin = new Padding(3, 4, 3, 4);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(1111, 906);
            listViewOrders.TabIndex = 3;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columname
            // 
            columname.Text = "Name";
            columname.Width = 200;
            // 
            // columnproduct
            // 
            columnproduct.Text = "Product";
            columnproduct.Width = 150;
            // 
            // columnquality
            // 
            columnquality.Text = "Quantity";
            columnquality.Width = 90;
            // 
            // columnarriveDate
            // 
            columnarriveDate.Text = "Arrive Date";
            columnarriveDate.Width = 500;
            // 
            // Filterabel
            // 
            Filterabel.AutoSize = true;
            Filterabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Filterabel.Location = new Point(3, 50);
            Filterabel.Name = "Filterabel";
            Filterabel.Size = new Size(50, 20);
            Filterabel.TabIndex = 3;
            Filterabel.Text = "Filter:";
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(59, 47);
            FilterTextBox.Margin = new Padding(3, 4, 3, 4);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(114, 27);
            FilterTextBox.TabIndex = 2;
            FilterTextBox.TextChanged += FilterTextBox_TextChanged;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, toolStripMenuItem7, toolStripMenuItem10 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 2, 0, 2);
            menuStrip2.Size = new Size(950, 28);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 24);
            toolStripMenuItem1.Text = "Client";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(120, 26);
            toolStripMenuItem2.Text = "Add";
            toolStripMenuItem2.Click += addToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(120, 26);
            toolStripMenuItem3.Text = "List";
            toolStripMenuItem3.Click += listToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(61, 24);
            toolStripMenuItem4.Text = "Order";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(138, 26);
            toolStripMenuItem5.Text = "Accept";
            toolStripMenuItem5.Click += acceptToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(138, 26);
            toolStripMenuItem6.Text = "List";
            toolStripMenuItem6.Click += listToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem8, toolStripMenuItem9 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(74, 24);
            toolStripMenuItem7.Text = "Product";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(120, 26);
            toolStripMenuItem8.Text = "Add";
            toolStripMenuItem8.Click += addToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(120, 26);
            toolStripMenuItem9.Text = "List";
            toolStripMenuItem9.Click += listToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem11, closeAppToolStripMenuItem1 });
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(74, 24);
            toolStripMenuItem10.Text = "Log out";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(160, 26);
            toolStripMenuItem11.Text = "Exit";
            toolStripMenuItem11.Click += exitToolStripMenuItem_Click;
            // 
            // closeAppToolStripMenuItem1
            // 
            closeAppToolStripMenuItem1.Name = "closeAppToolStripMenuItem1";
            closeAppToolStripMenuItem1.Size = new Size(160, 26);
            closeAppToolStripMenuItem1.Text = "Close App";
            closeAppToolStripMenuItem1.Click += closeAppToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1539, 840);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ware House";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox passwordTextBoxP1;
        private TextBox loginTextBoxP1;
        private ListView listViewClients;
        private ColumnHeader columnName;
        private ColumnHeader columnSurname;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem acceptToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem listToolStripMenuItem2;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button viewButton;
        private Button SignUpButton;
        private Button SignInButton;
        private ColumnHeader columnEmail;
        private ColumnHeader columnPhone;
        private ColumnHeader columnAdress;
        private Panel panel3;
        private Label Filterabel;
        private TextBox FilterTextBox;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ListView listViewProducts;
        private ColumnHeader columnProductName;
        private ColumnHeader columnProductPrice;
        private ColumnHeader columnProductQuality;
        private ColumnHeader columnProductDescription;
        private ToolStripMenuItem closeAppToolStripMenuItem;
        private ToolStripMenuItem closeAppToolStripMenuItem1;
        private ListView listViewOrders;
        private ColumnHeader columname;
        private ColumnHeader columnproduct;
        private ColumnHeader columnquality;
        private ColumnHeader columnarriveDate;
        private PictureBox pictureBox1;
    }
}