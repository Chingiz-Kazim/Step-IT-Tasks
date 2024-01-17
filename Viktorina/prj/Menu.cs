using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prj
{
    public class Menu : Program
    {
        public static void SavePlayers(XmlSerializer saveplayers, ref Users players)
        {
            using (Stream stream = File.Create("../../../../players.txt"))
            {
                saveplayers.Serialize(stream, players);
            }
        }

        public static void SaveQuestions(XmlSerializer savequestions, ref Questions questions)
        {
            using (Stream stream = File.Create("../../../../questions.txt"))
            {
                savequestions.Serialize(stream, questions);
            }
        }

        public static void LoadPlayers(XmlSerializer saveplayers, ref Users players)
        {
            using (Stream stream = File.OpenRead("../../../../players.txt"))
            {
                players = (Users)saveplayers.Deserialize(stream);
            }
        }

        public static void LoadQuestions(XmlSerializer savequestions, ref Questions questions)
        {
            using (Stream stream = File.OpenRead("../../../../questions.txt"))
            {
                questions = (Questions)savequestions.Deserialize(stream);
            }
        }
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Начать новую викторину");
            Console.WriteLine("\t\t\t2 - Посмотреть результаты своих прошлых викторин");
            Console.WriteLine("\t\t\t3 - Посмотреть Топ-20 по викторине");
            Console.WriteLine("\t\t\t4 - Изменить настройки");
            Console.WriteLine("\t\t\t5 - Выход");
            Console.WriteLine("\t\t==============================================================");
        }

        public static void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Добавить вопрос");
            Console.WriteLine("\t\t\t2 - Удалить вопрос");
            Console.WriteLine("\t\t\t3 - Выход");
            Console.WriteLine("\t\t==============================================================");
        }

        public static void AdminEnter()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t  Добро пожаловать в приложение \"Викторина\"! ");
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Войти");
            Console.WriteLine("\t\t==============================================================");
        }

        public static int GetChoice()
        {
            Console.Write("\n>  Выберите нужное действие: ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice); 
            return choice;
            
        }
        public static void RegistMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t  Добро пожаловать в приложение \"Викторина\"! ");
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Войти");
            Console.WriteLine("\t\t\t2 - Зарегестрироваться");
            Console.WriteLine("\t\t==============================================================");
        }
        public static void ShowQuizMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - История");
            Console.WriteLine("\t\t\t2 - Физика");
            Console.WriteLine("\t\t\t3 - Смешаная викторина");
            Console.WriteLine("\t\t==============================================================");
        }
        public static void ShowChangeSetMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Изменить дату рождения");
            Console.WriteLine("\t\t\t2 - Изменить пароль");
            Console.WriteLine("\t\t==============================================================");
        }
        public static bool AllowContinue()
        {
            Console.Write("\n>  Продолжить ('y' чтоб ДА / 'n' чтоб НЕТ)? - ");
            string answer = Console.ReadLine();
            return answer == "y" ? true : false;
        }

        //eto perviy variant s 1 otvetom

        public static void QuizMenu(User user, Questions questions)
        {
            try
            {
                Console.Clear();
                ShowQuizMenu();
                Console.WriteLine();
                Console.Write(">  Выберете в какой области вы хотите проверить свои знания: ");
                int choiceQuiz = Int32.Parse(Console.ReadLine());
                var viktorina = questions.questionsH;
                if (choiceQuiz == 1) viktorina = questions.questionsH;
                else if (choiceQuiz == 2) viktorina = questions.questionsP;
                else if(choiceQuiz == 3) viktorina = questions.questionsMix;
                foreach (var vopros in viktorina)
                {
                    Console.WriteLine($"\t\t\t{vopros}");
                    Console.Write($"\n\t\t\t>Ваш ответ: ");
                    string otvet = Console.ReadLine();
                    if ((otvet == "A" || otvet == "a") && vopros.Answers[0].Corect)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tПравильно\n");
                        Console.ResetColor();
                        user.Score++;
                    }
                    else if ((otvet == "B" || otvet == "b") && vopros.Answers[1].Corect)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tПравильно\n");
                        Console.ResetColor();
                        user.Score++;
                    }
                    else if ((otvet == "C" || otvet == "c") && vopros.Answers[2].Corect)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tПравильно\n");
                        Console.ResetColor();
                        user.Score++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\tНеправильно\n");
                        Console.ResetColor();
                        foreach (var ot in vopros.Answers)
                        {
                            if (ot.Corect)
                            {
                                Console.WriteLine($"\t\t\tПравильный ответ - \"{ot}\"\n");
                            }
                        }
                        Console.ResetColor();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  Неверный символ!\n");
                Console.ResetColor();
            }
        }

        // eto 2 variant s dvuma otvetami


        //public static void QuizMenu(User user, Questions questions)
        //{
        //    try
        //    {


        //        Console.Clear();
        //        //ShowQuizMenu(); 
        //        Console.WriteLine();
        //        Console.Write(">  Выберете в какой области вы хотите проверить свои знания: ");
        //        int choiceQuiz = Int32.Parse(Console.ReadLine());
        //        var viktorina = questions.questionsH;
        //        if (choiceQuiz == 1) viktorina = questions.questionsH;
        //        else if (choiceQuiz == 2) viktorina = questions.questionsP;
        //        //else if(choiceQuiz == 3) viktorina = questions.mix; 
        //        foreach (var vopros in viktorina)
        //        {
        //            Console.WriteLine($"\t\t\t{vopros}");
        //            Console.Write($"\n\t\t\t>Ваш ответ: ");
        //            string otvet = Console.ReadLine();
        //            string[] temp = otvet.Split(' ');
        //            otvet = temp[0];
        //            string otvet2 = temp[1];
        //            if (((otvet.ToLower() == "a" || otvet2.ToLower() == "a") && vopros.Answers[0].Corect))
        //            {
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("\t\t\tПравильно");
        //                Console.ResetColor();
        //                user.Score++;
        //            }
        //            if ((otvet == "B" || otvet == "b") && vopros.Answers[1].Corect)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("\t\t\tПравильно");
        //                Console.ResetColor();
        //                user.Score++;
        //            }
        //            if ((otvet == "C" || otvet == "c") && vopros.Answers[2].Corect)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("\t\t\tПравильно");
        //                Console.ResetColor();
        //                user.Score++;
        //            }



        //            //else 
        //            if ((otvet.ToLower() == "a"(otvet.ToLower() == "b"(otvet.ToLower() == "c"(otvet.ToLower() == "d" || otvet2.ToLower() == "d")) { }
        //            else { }

        //            //else 
        //            //{ 
        //            //    Console.ForegroundColor = ConsoleColor.Red; 
        //            //    Console.WriteLine("\t\t\tНерравильно"); 
        //            //    Console.ResetColor(); 
        //            //    foreach (var ot in vopros.Answers) 
        //            //    { 
        //            //        if (ot.Corect) 
        //            //        { 
        //            //            Console.WriteLine($"\t\t\tПравильный ответ - \"{ot}\"\n"); 
        //            //        } 
        //            //    } 
        //            //    Console.ResetColor(); 
        //            //} 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"  Неверный символ!\n");
        //    }
        //}
    }

}
