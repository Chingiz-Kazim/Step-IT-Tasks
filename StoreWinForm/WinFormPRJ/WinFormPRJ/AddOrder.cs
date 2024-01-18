using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Serialization;

namespace WinFormPRJ
{
    public partial class AddOrder : Form
    {
        public static ListViewItem lstviewO;

        public static int CH;

        public static string? LOGIN;

        XmlSerializer SVproducts = new XmlSerializer(typeof(Products));
        XmlSerializer SVusers = new XmlSerializer(typeof(Users));
        public AddOrder()
        {
            InitializeComponent();
            foreach (var item in Form1.users.users)
            {
                foreach (var i in item.clients)
                {
                    if (item.Login == Customer.LOGIN)
                        ClientNameComboBox.Items.Add(i.Name);

                }
            }
            foreach (var item in Form1.products.products)
            {
                ProductNameComboBox.Items.Add(item.Name);
            }
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            if (ClientNameComboBox.Text !="" && QuantityProducNumericUpDown.Text !="" && ProductNameComboBox.Text !="" && dateTimePickerForOrder.Text != "" && dateTimePickerForOrder.Value>=DateTime.Now)
            {

                bool flag = false;
                Order newOrder = new Order() { clientName = ClientNameComboBox.Text, CountProduct = Int32.Parse(QuantityProducNumericUpDown.Text), NameProduct = ProductNameComboBox.Text, dateTime = dateTimePickerForOrder.Value };
                Form1.users.orders.Add(newOrder);
                foreach (var item in Form1.products.products)
                {
                    if (item.Name == newOrder.NameProduct)
                    {
                        if (Int32.Parse(QuantityProducNumericUpDown.Text) <= item.Quality)
                        {
                            item.Quality -= Int32.Parse(QuantityProducNumericUpDown.Text);
                            flag = true;

                            this.Close();

                        }
                        else MessageBox.Show($"В наличие нет такого количества товара.\nНа складе:{item.Quality}", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (flag)
                {
                    foreach (var item in Form1.users.users)
                    {
                        if (item.Login==LOGIN)
                        {
                            item.orders.Add(newOrder);
                        }
                    }
                    lstviewO = new ListViewItem(newOrder.clientName);
                    lstviewO.SubItems.Add(newOrder.NameProduct);
                    lstviewO.SubItems.Add(newOrder.CountProduct.ToString());
                    lstviewO.SubItems.Add(newOrder.dateTime.ToShortDateString());
                    MessageBox.Show($"Заказ оформлен успешно.", $"Customer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CH++;
                    flag = false;

                    using (Stream fstream1 = File.Create("../../../../products.txt"))
                    {
                        SVproducts.Serialize(fstream1, Form1.products);
                    }
                    using (Stream fstream2 = File.Create("../../../../users.txt"))
                    {
                        SVusers.Serialize(fstream2, Form1.users);
                    }

                    this.Close();
                }
            }
            else MessageBox.Show("Заполните все поля", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
