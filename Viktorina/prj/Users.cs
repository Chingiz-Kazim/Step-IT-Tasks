using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj
{
    public class Users
    {
        
        public List<User> players = new List<User>()
        {
            //new User()
            //{
            //    Results = new List<int>(),
            //    Login = "admin",
            //    Password = "admin",
            //    Birthday = DateTime.Now,
            //    Score = 0,
            //},
            //new User(){
            //    Results = new List<int>(){ 11, 12 },
            //    Login = "Ugur",
            //    Password = "777",
            //    Birthday = new DateTime(2007,01,21),
            //    Score = 0
            //},
            //new User(){
            //    Results = new List<int>(){ 7, 3, 9 },
            //    Login = "Farid",
            //    Password = "dbv",
            //    Birthday=new DateTime(1996,06,30),
            //    Score = 0

            //}

        };

        public Users() {}

        //private bool CheckUserExists(string login)
        //{
        //    return FindUser(login) != null;
        //}
        //public User FindUser(string login)
        //{
        //    return this.FirstOrDefault(u => u.Login == login);
        //}
    }
}
