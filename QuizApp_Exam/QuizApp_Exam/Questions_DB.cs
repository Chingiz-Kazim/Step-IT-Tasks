using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Exam
{
    internal class Questions_DB
    {

       public List<Question> questions = new List<Question>
        {
             new Question()
             {
                 Text = "kak dela?",
                 Answers = new List<Answer>()
                {
                    new Answer() { Text = "xorosho", IsCorrect=false },
                    new Answer() { Text = "ploxo", IsCorrect=false },
                    new Answer() { Text = "normalno", IsCorrect=true },
                    new Answer() { Text = "tak sebe", IsCorrect=false },
                }
             },
             new Question()
             {
                 Text = "kak zovut?",
                 Answers = new List<Answer>()
                {
                    new Answer() { Text = "Dushberik", IsCorrect=false },
                    new Answer() { Text = "Farid", IsCorrect=true },
                    new Answer() { Text = "Ugur", IsCorrect=false },
                    new Answer() { Text = "Moguda", IsCorrect=false },
                }
             }
             };

    }
}
