using System;

namespace C_Basics_AbstractClass
{
    //Why And When To Use Abstract Classes and Methods?
    //To achieve security - hide certain details and only show the important details of an object.
    //Note: Abstraction can also be achieved with Interfaces
    public abstract class Animal
    {
        public string Name { get; set; } = "Cat";

        //can only be used in an abstract class, and it does not have a body. 
        public abstract void Method();

        public string GetName()
        {
            return Name;
        }
    }
    class Program : Animal
    {
        public override void Method()
        {
            Console.WriteLine("Overrided");
        }
        static void Main(string[] args)
        {
            Program ps = new Program();
            Console.WriteLine("Hello World!");
            // Cannot create an instance of the abstract type or interface 'Animal' 
            //Animal an = new Animal();
            //an.GetName();
            Console.WriteLine(ps.GetName());
            ps.Method();
        }
    }
}
