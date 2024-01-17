using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Exam
{
    internal class User
    {

        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }

        public int Score { get; set; }

        public ArrayList Records { get; set ; }

        public User() {}

        public User(string login, string password, DateTime birthday)
        {
            Login = login;
            Password = password;
            Birthday = birthday;
        }


       

        public void UserSignUp()
        {
            Console.WriteLine("\t\t\tEnter new user data");
            Console.ResetColor();
            Console.Write("\t\t\tLogin: ");
            Login = Console.ReadLine();
            Console.Write("\t\t\tPassword: ");
            Password = Console.ReadLine();
            Console.Write("\t\t\tEnter birthdate (yyyy-mm-dd): ");
            Birthday = DateTime.Parse(Console.ReadLine());
          
        }

        public void UserSignIn()
        {
            Console.ResetColor();
            Console.Write("\t\t\tLogin: ");
            Login = Console.ReadLine();
            Console.Write("\t\t\tPassword: ");
            Password = Console.ReadLine();
           
        }


 
    }
}
