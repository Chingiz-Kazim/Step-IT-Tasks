using System.Xml.Serialization;

namespace WinFormPRJ
{
    public partial class Form1 : Form
    {
        public static User user = new User();
        public static Users users = new Users();

        public static Order order = new Order();

        public static Product product = new Product();
        public static Products products = new Products();

        XmlSerializer LOADusers = new XmlSerializer(typeof(Users));
        XmlSerializer LOADproducts = new XmlSerializer(typeof(Products));

        public Form1()
        {
            InitializeComponent();
            Size size = new Size(950, 950);
            this.Size = size;
            panel2.Size = size;
            panel3.Size = size;
            panel1.Size = size;
            panel1.Dock = DockStyle.Fill;
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            listViewClients.Visible = true;
            listViewProducts.Visible = false;

            using (Stream fstream = File.OpenRead("../../../../users.txt"))
            {
                users = (Users)LOADusers.Deserialize(fstream);
            }

            using (Stream fstream1 = File.OpenRead("../../../../products.txt"))
            {
                products = (Products)LOADproducts.Deserialize(fstream1);
            }

        }

        public void UpdateProductsList()
        {
            listViewProducts.Items.Clear();
            foreach (var j in products.products)
            {
                ListViewItem listview = new ListViewItem(j.Name);
                listview.SubItems.Add(j.Price.ToString());
                listview.SubItems.Add(j.Quality.ToString());
                listview.SubItems.Add(j.Description);
                listViewProducts.Items.Add(listview);
            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (var item in users.users)
            {
                if (loginTextBoxP1.Text == item.Login && passwordTextBoxP1.Text == item.Password)
                {
                    this.Size = new Size(950, 950);
                    panel2.Dock = DockStyle.Fill;
                    panel1.Hide();
                    panel2.Show();
                    panel3.Hide();
                    listViewClients.Visible = true;
                    listViewProducts.Visible = false;
                    c++;
                    Customer.LOGIN = loginTextBoxP1.Text;
                    AddOrder.LOGIN = loginTextBoxP1.Text;
                    foreach (var i in item.clients)
                    {
                        ListViewItem listview = new ListViewItem(i.Name);
                        listview.SubItems.Add(i.Surname);
                        listview.SubItems.Add(i.Email);
                        listview.SubItems.Add(i.Phone);
                        listview.SubItems.Add(i.Adress);
                        listViewClients.Items.Add(listview);
                    }

                    UpdateProductsList();

                    foreach (var k in item.orders)
                    {
                        ListViewItem listview = new ListViewItem(k.clientName);
                        listview.SubItems.Add(k.NameProduct);
                        listview.SubItems.Add(k.CountProduct.ToString());
                        listview.SubItems.Add(k.dateTime.ToString());
                        listViewOrders.Items.Add(listview);
                    }
                }
            }
            if (c == 0)
            {
                MessageBox.Show("неверный ввод", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            loginTextBoxP1.Text = "";
            passwordTextBoxP1.Text = "";
        }

        private void viewButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBoxP1.UseSystemPasswordChar = false;
        }

        private void viewButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBoxP1.UseSystemPasswordChar = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
            if (Customer.CH != 0)
            {

                listViewClients.Items.Add(Customer.lstview);
                listViewClients.Visible = true;
                listViewProducts.Visible = false;
                Customer.CH = 0;
            }

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 950);
            panel1.Hide();
            panel2.Show();
            panel3.Hide();

            panel2.Dock = DockStyle.Fill;
            listViewClients.Visible = true;
            listViewProducts.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginTextBoxP1.Text = "";
            passwordTextBoxP1.Text = "";
            Size size = new Size(950, 950);
            this.Size = size;
            panel2.Size = size;
            panel3.Size = size;
            panel1.Size = size;
            panel1.Dock = DockStyle.Fill;
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            listViewClients.Items.Clear();
            listViewProducts.Items.Clear();
            listViewOrders.Items.Clear();
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult EXIT = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EXIT == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product_order product = new Product_order();
            product.ShowDialog();
            if (Product_order.CH != 0)
            {
                listViewProducts.Items.Add(Product_order.lstviewP);
                this.Size = new Size(950, 950);
                listViewProducts.Visible = true;
                listViewClients.Visible = false;
                panel1.Hide();
                panel2.Show();
                panel3.Hide();
                panel2.Dock = DockStyle.Fill;
                Product_order.CH = 0;
            }
            UpdateProductsList();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 950);
            listViewProducts.Visible = true;
            listViewClients.Visible = false;
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel2.Dock = DockStyle.Fill;
            UpdateProductsList();

        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(680, 600);
            listViewProducts.Visible = false;
            listViewClients.Visible = false;
            panel3.Size = this.Size;
            panel3.Dock = DockStyle.Fill;
            panel1.Hide();
            panel2.Hide();
            panel3.Show();

        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(680, 600);
            listViewProducts.Visible = false;
            listViewClients.Visible = false;
            panel3.Size = this.Size;
            AddOrder order = new AddOrder();
            order.ShowDialog();
            if (AddOrder.CH != 0)
            {
                listViewOrders.Items.Add(AddOrder.lstviewO);
                AddOrder.CH = 0;
            }
            panel3.Dock = DockStyle.Fill;
            panel1.Hide();
            panel2.Hide();
            panel3.Show();

        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            listViewOrders.Items.Clear();
            foreach (var item in users.users)
            {
                foreach (var mal in item.orders)
                {
                    if (item.Login == loginTextBoxP1.Text)
                    {
                        if (mal.clientName.ToLower().Contains(FilterTextBox.Text.ToLower()) || mal.NameProduct.ToLower().Contains(FilterTextBox.Text.ToLower()))
                        {
                            ListViewItem listview = new ListViewItem(mal.clientName);
                            listview.SubItems.Add(mal.NameProduct);
                            listview.SubItems.Add(mal.CountProduct.ToString());
                            listview.SubItems.Add(mal.dateTime.ToString());
                            listViewOrders.Items.Add(listview);
                        }
                    }
                }
            }
        }
    }
}