using System;

namespace C_Basics_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var str; //A var variable must be initialized at the time of declaration.
            string str = null;
            var x = 10; //used to declare implicitly typed local variable =>
            //compiler to figure out the type of the variable
            // x = "STRING"; -- NoT possible
            Console.WriteLine(x);
            Console.WriteLine(str);
            Console.WriteLine("Hello World!");
        }
    }
}
