using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Exam
{
    internal class Users_DB
    {

      public  List<User> users = new()
        {
            new User()
            {
                Login = "farid",
                Password = "12345",
                Birthday = new DateTime(1996, 06, 30),
                Score = 0
            },
            new User()
            {
                Login = "step",
                Password = "123",
                Birthday = new DateTime(1993, 07, 20),
                Score = 15
            }

        };


    }
}
