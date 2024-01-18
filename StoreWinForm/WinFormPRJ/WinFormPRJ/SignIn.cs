using System.Xml.Serialization;
using static WinFormPRJ.Form1;

namespace WinFormPRJ
{
    public partial class SignIn : Form
    {
        XmlSerializer LoadSaveUsers = new XmlSerializer(typeof(Users));
        public SignIn()
        {
            InitializeComponent();
            using (Stream fstream = File.OpenRead("../../../../users.txt"))
            {
                users = (Users)LoadSaveUsers.Deserialize(fstream);
            }
            toolTip1.SetToolTip(LogintextBox, "Минимум 5 символов");
            toolTip1.SetToolTip(PastextBox, "Минимум 5 символов");
        }

        public bool loginPassLenghtCheck(string value)
        {
            if (value.Length > 4) return true;
            else return false;
        }

        private void DONEbutton_Click(object sender, EventArgs e)
        {
            if (LogintextBox.Text != "" && PastextBox.Text != "" && RePastextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != ""
                && loginPassLenghtCheck(LogintextBox.Text) && loginPassLenghtCheck(PastextBox.Text) && Customer.nameLenghtCheck(NameTextBox.Text) && Customer.nameLenghtCheck(SurnameTextBox.Text))
            {
                int check = 0;
                foreach (var item in users.users)
                {
                    if (LogintextBox.Text == item.Login)
                    {
                        MessageBox.Show($" {LogintextBox.Text} логин уже существует", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.Sleep(2000);
                        check++;
                    }

                }

                if (PastextBox.Text != RePastextBox.Text)
                {
                    MessageBox.Show("Введенные пароли не идентичны", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check++;
                }

                if (check == 0)
                {
                    users.users.Add(new User(){ Login = LogintextBox.Text, Password = PastextBox.Text, Name = NameTextBox.Text, Surname = SurnameTextBox.Text });
                    MessageBox.Show($"Регистрация прошла успешно для {LogintextBox.Text}", $"Добро Пожаловать!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    using (Stream fstream = File.Create("../../../../users.txt"))
                    {
                        LoadSaveUsers.Serialize(fstream, Form1.users);
                    }

                    this.Close();
                }
            }
            else { MessageBox.Show("Заполните все поля", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
        }

    }
}
