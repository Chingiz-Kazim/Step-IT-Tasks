using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj
{
    public class Answer
    {
        public string? Answ_Text { get; set; }
        public bool Corect { get; set; }

        public Answer(){}

        public Answer(string? answ_Text, bool corect)
        {
            Answ_Text = answ_Text;
            Corect = corect;
        }

        public override string? ToString()
        {
            return $"{Answ_Text}";
        }
    }
}
