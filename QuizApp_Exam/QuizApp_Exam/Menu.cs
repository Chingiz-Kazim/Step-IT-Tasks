using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Exam
{
    internal class Menu
    {
        
        public void MainMenu()
        {
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Start new game");
            Console.WriteLine("\t\t\t2 - Past Results");
            Console.WriteLine("\t\t\t3 - Top-20");
            Console.WriteLine("\t\t\t4 - Settings");
            Console.WriteLine("\t\t\t0 - Exit");
            Console.WriteLine("\t\t==============================================================");
            Console.Write("\t\tSelect command: ");
        }

        public void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\tWelcome to Quiz App");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - Sign In");
            Console.WriteLine("\t\t\t2 - Sign Up");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.Write("\t\tSelect command: ");
        }



        public void  QuizMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - History");
            Console.WriteLine("\t\t\t2 - Geography");
            Console.WriteLine("\t\t\t3 - Mixed");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.Write("\t\tSelect topic: ");
        }


        public  void SettingsMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - Change user birthdate");
            Console.WriteLine("\t\t\t2 - Change user password");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.Write("\t\tSelect command: ");
        }

    }
}
