using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPRJ
{
    public class Client
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }
        public Client()
        {
        }

        public Client(string? name, string? surname, string? email, string? phone, string? adress)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Adress = adress;
        }

        public Client(string? name)
        {
            Name = name;
        }
    }
}
