using System;

namespace QuizApp_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

              Users_DB users = new Users_DB();
              Questions_DB questions = new Questions_DB();
                bool flaq = true;
                int choice;
                int choice2;
                Menu menu = new Menu();
                User user = new User();
                user.Records = new System.Collections.ArrayList();
                int check = 0;
                int check2 = 0;
                do
                {
                    menu.LoginMenu();
                    choice = Int32.Parse(Console.ReadLine());
                    check = 0;
                    check2= 0;

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            user.UserSignIn();
                            
                            foreach (var item in users.users)
                            {
                                 if (item.Login==user.Login && item.Password == user.Password)
                                { Console.WriteLine($"\n\t\t\tLogin succesfull! Welcome, {user.Login}");
                                    flaq = false;
                                    check++;
                                }
                                
                            }
                            if (check == 0)
                            { 
                                Console.WriteLine("\n\t\t\tWrong username or password!");
                                Thread.Sleep(1000);
                                flaq = true;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            user.UserSignUp();
                           
                            foreach (var item in users.users)
                            {
                                if (user.Login==item.Login )
                                {
                                    Console.WriteLine($"\n\t\t\t User {user.Login}  already exists, Please try again. ");
                                    Thread.Sleep(1500);
                                    flaq = true;
                                    check2++;
                                }
                            }
                            if (check2 == 0)
                            {
                                Console.WriteLine($"\n\t\t\tNew user succefully crated! Please sign in.");
                                Thread.Sleep(1500);
                                users.users.Add(new User() { Login = user.Login, Password = user.Password, Birthday = user.Birthday,  });
                                flaq = true;

                            };
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\t\t\tWrong input");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                } while ( flaq );

                do
                {
                    menu.MainMenu();
                    choice2 = Int32.Parse(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            Console.Clear();
                            // menu.QuizMenu();
                            foreach (var quest in questions.questions)
                            {
                                Console.WriteLine($"\t\t\t{ quest}");
                             
                                string otvet = Console.ReadLine();
                                otvet = otvet.ToLower();
                                // if (question.CheckAnswer(otvet)) Console.WriteLine("Pravilno");
                                if (otvet == "a" && quest.Answers[0].IsCorrect)
                                {
                                    Console.WriteLine("\t\t\tPravilno");
                                    user.Score++;
                                }
                               else if (otvet == "b" && quest.Answers[1].IsCorrect)
                                {
                                    Console.WriteLine("\t\t\tPravilno");
                                    user.Score++;
                                }
                                else if (otvet == "c" && quest.Answers[2].IsCorrect)
                                {
                                    Console.WriteLine("\t\t\tPravilno");
                                    user.Score++;
                                }
                                else if (otvet == "d" && quest.Answers[3].IsCorrect)
                                {
                                    Console.WriteLine("\t\t\tPravilno");
                                    user.Score++;
                                }
                                else Console.WriteLine("\t\t\t Ne Pravilno");
                            }
                                Console.WriteLine($"\t\t\tYour Score:{user.Score}");

                                user.Records.Add(user.Score);

                            foreach (var item in users.users)
                            {
                                if (item.Login == user.Login)
                                {
                                    item.Score = user.Score;

                                }
                            }
                                user.Score = 0;

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"\t\t\tPast Results:\n");
                            foreach (var item in user.Records)
                            { Console.WriteLine($"\t\t\t{ user.Login} -- Score: {item}"); }

                            break;

                        case 3:
                            Console.Clear();

                            users.users.Sort(
                                delegate (User p1, User p2)
                                {
                                    return p2.Score.CompareTo(p1.Score);
                                }

                                );
                            foreach (var score in users.users)
                            {
    
                                Console.WriteLine($"\t\t\tUser: {score.Login} -- Score:{score.Score}" );
                            }
                            break;

                        case 4:
                            Console.Clear();
                            menu.SettingsMenu();
                            int setting = Int32.Parse(Console.ReadLine());
                            DateTime newbirthday;
                            string newpassword;
                            string oldpassword;
                            if (setting == 1)
                            {
                                foreach(var item in users.users)
                                {
                                    if (item.Login == user.Login)
                                    {
                                        Console.Write("\t\t\tEnter new birthday: ");
                                        newbirthday= DateTime.Parse(Console.ReadLine());
                                        item.Birthday = newbirthday;
                                        
                                            }
                                }
                                Console.WriteLine("\t\t\tBirthday was succesfully changed.");
                            }

                            if (setting == 2)
                            {
                                foreach (var item in users.users)
                                {
                                    if (item.Login == user.Login)
                                    {
                                        Console.Write("\t\t\tEnter old password: ");
                                        oldpassword = Console.ReadLine();
                                        if (oldpassword == item.Password)
                                        {
                                            newpassword = Console.ReadLine();
                                            item.Password = newpassword;
                                            Console.WriteLine("\t\t\tPassword was succesfully changed.");
                                        }
                                        else Console.WriteLine("\t\t\tOld password is wrong.");

                                    }
                                }
                               ;
                            }
                            break;
                        case 5:
                            foreach (var i in users.users)
                            {
                                Console.WriteLine(i.Login);
                                Console.WriteLine(i.Password);
                                Console.WriteLine(i.Birthday);
                                Console.WriteLine();
                            }
                            break;
                        case 0:
                            Console.Clear();
                            Console.Write("\t\t\t\tClosing the application\n");
                            Console.Write("\t\t\t\t       .");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".\n");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\t\t\tWrong input");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }
                } while (choice2 != 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t\t\t\t{ex.Message}\n" +
                    $"\t\t\t\tPlease try again.");
            }
            }


    }

}