using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Exam
{
    internal class QuestionListcs
    {
        
            List<Question> questions = new List<Question>
        {
            new Question()
            {
                Text = "kak dela?",
                Answers = new List<Answer> ()
                {
                    new Answer() { Text = "xorosho", IsCorrect=true },
                    new Answer() { Text = "ploxo", IsCorrect=false },
                    new Answer() { Text = "normalno", IsCorrect=false },
                    new Answer() { Text = "tak sebe", IsCorrect=false },
                }
            }
        };
        public override string ToString()
        {
            return $"{questions}";
        }
    }
}
