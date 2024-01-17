using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj
{
    public class Question
    {
        public string? Ques_Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(){}

        public Question(string? ques_Text, List<Answer> answers)
        {
            Ques_Text = ques_Text;
            Answers = answers;
        }

        public override string? ToString()
        {
            return $"{Ques_Text}:" +
            $"\nA){Answers[0]}" +
            $"\nB){Answers[1]}" +
            $"\nC){Answers[2]}";
        }
    }
}
