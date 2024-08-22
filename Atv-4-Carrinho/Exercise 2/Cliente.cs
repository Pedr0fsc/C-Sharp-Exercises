using System;

namespace Bookstore
{
    public class Client
    {
        public string Name;
        public string Email;

        public Client(string name, string email)
        {
            Name = name;
            Email = email; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n" + $"Email: {Email}");
        }
    }
}
