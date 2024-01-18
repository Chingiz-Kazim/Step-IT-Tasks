using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Serialization;

namespace WinFormPRJ
{
    public partial class Product_order : Form
    {
        public static ListViewItem lstviewP;

        public static int CH;

        XmlSerializer SVproducts = new XmlSerializer(typeof(Products));
        public Product_order()
        {
            InitializeComponent();
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                if (textBoxForProductName.Text != "" && textBoxForProductPrice.Text != "" && numericUpDownQuality.Text != "" && textBoxForProductDescription.Text != ""
                    && (Double.Parse(textBoxForProductPrice.Text) > 0) && Customer.nameLenghtCheck(textBoxForProductName.Text) && !textBoxForProductPrice.Text.Contains('.'))
                {
                    Product newProduct = new Product() { Name = textBoxForProductName.Text, Price = Double.Parse(textBoxForProductPrice.Text), Quality = Int32.Parse(numericUpDownQuality.Text), Description = textBoxForProductDescription.Text };
                    foreach (var item in Form1.products.products)
                    {
                        if (item.Name == newProduct.Name)
                        {
                            item.Price = newProduct.Price;
                            item.Quality += newProduct.Quality;
                            item.Description = newProduct.Description;
                            MessageBox.Show($"Данные о товаре обновлены.", $"Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Form1.products.products.Add(newProduct);
                        lstviewP = new ListViewItem(newProduct.Name);
                        lstviewP.SubItems.Add(newProduct.Price.ToString());
                        lstviewP.SubItems.Add(newProduct.Quality.ToString());
                        lstviewP.SubItems.Add(newProduct.Description);
                        MessageBox.Show($"Товар добавлен.", $"Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CH++;
                    }

                    using (Stream fstream = File.Create("../../../../products.txt"))
                    {
                        SVproducts.Serialize(fstream, Form1.products);
                    }

                    this.Close();
                }
                else { MessageBox.Show("Заполните все поля", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некоторые поля заполнены неверно.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
