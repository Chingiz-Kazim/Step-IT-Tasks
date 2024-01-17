using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj
{
    public class Quiz
    {
        public QuizType Type { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz()
        {
        }

        public Quiz(QuizType type, List<Question> questions)
        {
            Type = type;
            Questions = questions;
        }
    }
    public enum QuizType
    {
        History,
        Physics,
        Mixed
    }
}
