using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj
{
    public class User
    {

        public List<int> Results { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public DateTime Birthday { get; set; }
        public int Score { get; set; }

        public User()
        {
            Results = new List<int>() { 0 } ;
        }

        public User(string? login, string? password)
        {
            Login = login;
            Password = password;
        }

        public void UserRegistration()
        {
            Console.WriteLine("\t\t\tЗаполните поля:");
            Console.Write("\t\t\tЛогин: ");
            Login = Console.ReadLine();
            Console.Write("\t\t\tПароль: ");
            Password = Console.ReadLine();
            Console.Write("\t\t\tДата рождения (yyyy-mm-dd): ");
            Birthday = DateTime.Parse(Console.ReadLine());
            Results = new List<int>(0);
            Score = 0;

        }

        public override string? ToString()
        {
            return $"Name: {Login}\t Password: {Password} Birthdate: {Birthday}";
        }

        public void UserEnter()
        {
            Console.Write("\t\t\tЛогин: ");
            Login = Console.ReadLine();
            Console.Write("\t\t\tПароль: ");
            Password = Console.ReadLine();
        }

        public void DisplayChangePassword(Users users, User user)
        {
            string newpassword, password;
            bool passwordCorrect = true;
                Console.Clear();
                foreach (var item in users.players)
                {
                    if (item.Login == user.Login)
                    {
                        Console.Write(">  Введите ваш старый пароль: ");
                        password = Console.ReadLine();
                    if (password == item.Password)
                    {
                        Console.Write(">  Введите новый пароль: ");
                        newpassword = Console.ReadLine();
                        item.Password = newpassword;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tИзменение прошло успешно");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный пароль!");
                        Console.ResetColor();
                    }
                    }
                }
        }
        public void DisplayChangeBirthday(Users users, User user)
        {
            DateTime newbirthday;
            Console.Clear();
            foreach (var item in users.players)
            {
                if (item.Login == user.Login)
                {
                    Console.Write(">  Введите новую дату рождения в формате(yy-mm-dd): ");
                    newbirthday = DateTime.Parse(Console.ReadLine());
                    item.Birthday = newbirthday;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tИзменение прошло успешно");
            Console.ResetColor();
        }
    }
}
