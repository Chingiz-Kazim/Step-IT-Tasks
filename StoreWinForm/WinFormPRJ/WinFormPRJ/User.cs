namespace WinFormPRJ
{
    public class User
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public List<Client> clients = new List<Client> { };
        public List<Order> orders = new List<Order> { };
        public User()
        {

        }

        public User(string? login)
        {
            Login = login;
        }

        public User(string? name, string? surname, string? login, string? password) : this(name)
        {
            Surname = surname;
            Login = login;
            Password = password;
        }

        public User(string? name, string? surname, string? login, string? password, List<Client> clients)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            this.clients = clients;
        }
    }
}
