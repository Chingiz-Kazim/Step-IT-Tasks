using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace prj
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer svusers = new XmlSerializer(typeof(Users));
            XmlSerializer svquestions = new XmlSerializer(typeof(Questions));
            Users users = new Users();
            User user = new User();
            Questions questions = new Questions();
            user.Results = new List<int> {  };
            bool exit = false;
            bool flag = true;
            int choice;
            int check = 0;
            try
            {
                Menu.LoadPlayers(svusers, ref users);
                Menu.LoadQuestions(svquestions, ref questions);
                do
                {
                    Menu.RegistMenu();
                    choice = Menu.GetChoice();
                    check = 0;
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            user.UserEnter();
                            foreach (var item in users.players)
                            {
                                if (item.Login == user.Login && item.Password == user.Password)
                                {
                                    Console.WriteLine($"\n\t\t\t Добро пожаловать, {item.Login}.");
                                    Thread.Sleep(1000);
                                    flag = false;
                                    check++;
                                }
                            }
                            if (check == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n\t\t\t(!)Неверный ввод логина или пароля.");
                                Console.ResetColor();
                                Thread.Sleep(1500);
                                flag = true;
                            }
                            check = 0;
                            break;
                        case 2:
                            Console.Clear();
                            user.UserRegistration();
                            foreach (var item in users.players)
                            {
                                if (user.Login == item.Login)
                                {
                                    Console.WriteLine($"\n\t\t\t Логин {user.Login}  уже существует. ");
                                    Thread.Sleep(1500);
                                    flag = true;
                                    check++;
                                }
                            }
                            if (check == 0)
                            {
                                users.players.Add(new User { Login = user.Login, Password = user.Password, Birthday = user.Birthday, Results = user.Results });
                                Console.WriteLine($"\n\t\t\tВы зарегестрировались успешно!");
                                Thread.Sleep(1500);
                                flag = true;
                            };
                            check = 0;
                            break;
                    }
                } while (flag);
                do
                {
                    Menu.ShowMainMenu();
                    switch (Menu.GetChoice())
                    {
                        case 1:
                            {
                                Menu.QuizMenu(user, questions);
                                Console.WriteLine();
                                Console.WriteLine($"Ваш результат: {user.Score} правильных ответов.");

                                foreach (var item in users.players)
                                {
                                    if (item.Login == user.Login)
                                    {
                                        item.Score = user.Score;
                                        item.Results.Add(user.Score);
                                    }
                                }
                                user.Score = 0;
                            }
                            break;
                        case 2:
                            foreach (var item in users.players)
                            {
                                if (item.Login == user.Login)
                                {
                                    for (int i = 1; i < item.Results.Count; i++)
                                    {
                                        Console.WriteLine($"\t\t\tЛогин игрока - {user.Login} -> Очки: {item.Results[i]} ");
                                    }
                                    break ;
                                }
                                if(item.Login != user.Login)
                                {
                                    Console.WriteLine($"\t\t Уважаемый {user.Login}, ваших результатов пока нет, начните викторину и проверьте свои знания, удачи. ");
                                    break;
                                }
                            }
                            break;
                        case 3:
                            {
                                try 
                                {
                                        users.players.Sort((x, y) => y.Results.Max().CompareTo(x.Results.Max()));
                                    foreach (var item in users.players)
                                    {
                                        Console.WriteLine($"\t\t\tЛогин: {item.Login} -> Очки: {item.Results.Max()}");
                                    }
                                }
                                catch(Exception ex) 
                                {
                                    Console.WriteLine($"\t\tПроверьте свои знания {user.Login} и затем посмотрите, попали ли вы в наш топ-20, удачи. ");
                                }
                            }
                            break;
                        case 4:
                            Menu.ShowChangeSetMenu();
                            switch (Menu.GetChoice())
                            {
                                case 1:
                                    user.DisplayChangeBirthday(users, user);
                                    break;
                                case 2:
                                    user.DisplayChangePassword(users, user);
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Неверный символ!");
                                    Console.ResetColor();
                                    break;
                            }
                            break;
                        case 5:
                            exit = true;
                            break;
                        case 6:
                            //скрытый кейс для проверok
                            foreach (var item in users.players)
                            {
                                Console.WriteLine(item);
                            }
                            Thread.Sleep(1500);

                            break;
                        default:
                            Console.WriteLine("  Неверный символ!");
                            break;
                    }
                    if (exit)
                    {
                      Menu.SavePlayers(svusers, ref users);
                      Menu.SaveQuestions(svquestions, ref questions);
                        break;
                    }
                    
                } while (Menu.AllowContinue());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t\t\t(!) Ошибка: {ex.Message}");
            }
        }
    }
}