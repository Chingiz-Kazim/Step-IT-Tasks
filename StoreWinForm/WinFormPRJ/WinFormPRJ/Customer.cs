using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static WinFormPRJ.Form1;

namespace WinFormPRJ
{
    public partial class Customer : Form
    {
        public static int CH;

        public static string LOGIN;

        public static ListViewItem lstview;

        XmlSerializer SVusers = new XmlSerializer(typeof(Users));
        public Customer()
        {
            InitializeComponent();
        }

        public static bool nameLenghtCheck(string value)
        {
            if (value.Length >= 2) return true;
            else return false;
        }


        public static bool IsValidPhone(string number)
        {
            if (number.Length == 18) return true;
            else return false;
        }
        public static string UpperFirstChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static bool IsValidEmail(string email) //взял с инета хорошо работает поэтому)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void SaveCustButton_Click(object sender, EventArgs e)
        {
            if (NameCustTextBox.Text != "" && SurnameCustTextBox.Text != "" && EmailCustTextBox.Text != "" && PhoneCustTextBox.Text != "" && AdressCustTextBox.Text != ""
                && IsValidEmail(EmailCustTextBox.Text) && IsValidPhone(PhoneCustTextBox.Text) && nameLenghtCheck(NameCustTextBox.Text) && nameLenghtCheck(SurnameCustTextBox.Text))
            {
                Client newClient = new Client() { Name = UpperFirstChar(NameCustTextBox.Text), Surname = UpperFirstChar(SurnameCustTextBox.Text), Email = EmailCustTextBox.Text, Phone = PhoneCustTextBox.Text, Adress = AdressCustTextBox.Text };
                foreach (var item in users.users)
                {
                    if (item.Login == LOGIN) item.clients.Add(newClient);

                }
                lstview = new ListViewItem(newClient.Name);
                lstview.SubItems.Add(newClient.Surname);
                lstview.SubItems.Add(newClient.Email);
                lstview.SubItems.Add(newClient.Phone);
                lstview.SubItems.Add(newClient.Adress);
                MessageBox.Show($"Сохранение прошло успешно.", $"Customer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CH++;

                using(Stream fstream = File.Create("../../../../users.txt"))
                {
                    SVusers.Serialize(fstream,users);
                }

                this.Close();
            }
            else 
            { 
                MessageBox.Show("Заполните все поля.\n\nПроверьте правильно ли введены данные.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
