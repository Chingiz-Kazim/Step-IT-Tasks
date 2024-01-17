using prj;
using System;
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
            user.Results = new List<int> { };
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
                    Menu.AdminEnter();
                    choice = Menu.GetChoice();
                    check = 0;
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            user.UserEnter();
                            foreach (var item in users.players)
                            {
                                if (user.Login == "admin" && user.Password == "admin")
                                {
                                    Console.WriteLine($"\n\t\t\t Добро пожаловать, Админ.");
                                    Thread.Sleep(1000);
                                    flag = false;
                                    check++;
                                    break;
                                }
                            }
                            if (check == 0)
                            {
                                Console.WriteLine($"\n\t\t\t(!)Неверный ввод логина или пароля.");
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
                    Menu.AdminMenu();
                    switch (Menu.GetChoice())
                    {
                        case 1:
                            Console.Clear();
                            Menu.ShowQuizMenu();
                            Console.WriteLine();
                            Console.Write(">  Выберете в какой области вы хотите сделать изменения: ");
                            int choiceQuiz = Int32.Parse(Console.ReadLine());
                            var viktorina = questions.questionsH;
                            if (choiceQuiz == 1) viktorina = questions.questionsH;
                            else if (choiceQuiz == 2) viktorina = questions.questionsP;
                            else if (choiceQuiz == 3) viktorina = questions.questionsMix;
                            Console.Write("\t\t\t> Введите вопрос: ");
                            string question = Console.ReadLine();
                            Console.Write("\t\t\t> Введите ответ №1: ");
                            string answer1 = Console.ReadLine();
                            Console.Write("\n>  Ответ правильный? ('y' чтоб ДА / 'n' чтоб НЕТ)? - ");
                            string c = Console.ReadLine();
                            bool correct1;
                            correct1 = c == "y" ? (correct1=true) : (correct1=false);

                            Console.Write("\t\t\t> Введите ответ №2: ");
                            string answer2 = Console.ReadLine();
                            Console.Write("\n>  Ответ правильный? ('y' чтоб ДА / 'n' чтоб НЕТ)? - ");
                            c = Console.ReadLine();
                            bool correct2;
                            correct2 = c == "y" ? (correct2 = true) : (correct2 = false);

                            Console.Write("\t\t\t> Введите ответ №3: ");
                            string answer3 = Console.ReadLine();
                            Console.Write("\n>  Ответ правильный? ('y' чтоб ДА / 'n' чтоб НЕТ)? - ");
                            c = Console.ReadLine();
                            bool correct3;
                            correct3 = c == "y" ? (correct3 = true) : (correct3 = false);

                            viktorina.Add(

                               new Question()
                               {
                                   Ques_Text = question,
                                   Answers = new List<Answer>()
                                {
                                         new Answer() { Answ_Text = answer1, Corect=correct1 },
                                         new Answer() { Answ_Text = answer2, Corect=correct2 },
                                         new Answer() { Answ_Text = answer3, Corect=correct3 },
                                }
                               });
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t\tВопрос добавлен успешно. ");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.Clear();
                            Menu.ShowQuizMenu();
                            Console.WriteLine();
                            Console.Write(">  Выберете в какой области вы хотите сделать изменения: ");
                            int choiceQuizQ = Int32.Parse(Console.ReadLine());
                            var viktorinaQ = questions.questionsH;
                            if (choiceQuizQ == 1) viktorinaQ = questions.questionsH;
                            else if (choiceQuizQ == 2) viktorinaQ = questions.questionsP;
                            else if (choiceQuizQ == 3) viktorinaQ = questions.questionsMix;
                            int i = 0;
                            foreach (var item in viktorinaQ)
                            {
                                Console.WriteLine($"{i + 1}. {item}"); ;
                                Console.WriteLine();
                                i++;
                            }

                            Console.WriteLine("\t\t\t> Выберите номер вопроса для удаления: ");
                            int number = Int32.Parse(Console.ReadLine());
                            try
                            {
                                viktorinaQ.RemoveAt(number - 1);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\t\t\tВопрос удален из списка. ");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("\t\t\tВыберите из списка. ");
                                Thread.Sleep(1000);
                            }
                            Console.Clear();
                            break;
                        case 3:
                            exit = true;
                            break;
                       
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  Неверный символ!");
                            Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t\t\t(!) Ошибка: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
