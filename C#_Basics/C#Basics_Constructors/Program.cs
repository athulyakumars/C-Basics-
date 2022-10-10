using System;

namespace C_Basics
{
    class User
    {
        public string Name{ get; set; }
        public int Id { get; set; }

        public static int Sequence { get; set; }

        public User(string name, int id) // Parameterized constructor. 
        {
            this.Name = name;
            this.Id = id;
        }

        public User(User user) // Copy constructor
        {
            Name = user.Name;
            Id = user.Id;
        }

        private User()
        {
        }

        static User()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Athulya", 101);
            User userCopy = new User(user);
            //User userPrivate = new User("athulya"); -- Not Possible due to the Private
            User.Sequence = 1000; // Classname.Static Variable: Not possible to call a static variable with object.
            User.Sequence = 5000;
            Console.WriteLine("Param Constructor Data!\nName: " +user.Name + "\nId: " + user.Id ); 
            Console.WriteLine("Copy Constructor Data!\nName: " + userCopy.Name + "\nId: " + userCopy.Id);
            Console.WriteLine("Private Constructor -Static Data access only!\n Sequence: " + User.Sequence);
        }
    }
}
