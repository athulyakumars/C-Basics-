using System;

namespace C_Basics_Interface
{
    public interface ITest
    {

        //An interface is a completely "abstract class", which can only contain abstract methods 
        //and properties (with empty bodies)
        //By default, members of an interface are abstract and public.
        //Note: Interfaces can contain properties and methods, but not fields.
        //Interfaces cannot contain instance fields
        //Why And When To Use Interfaces?
        //1) To achieve security - hide certain details and only show the important details
        // of an object (interface).

        //2) C# does not support "multiple inheritance" (a class can only inherit from one base class).
        // However, it can be achieved with interfaces, 
        //because the class can implement multiple interfaces. Note: To implement multiple interfaces,
        // separate them with a comma
        
        //string x;

        //public string Name { get; set; }

        public string GetName();

        public void Display(string name);
    }
    class Program : ITest
    {
        
        public string GetName()
        {
            return "ABC";
        }

        public void Display(string name)
        {
            Console.WriteLine("Name is " + name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program ps = new Program();
            string name = ps.GetName();
            ps.Display(name);
        }
    }
}
