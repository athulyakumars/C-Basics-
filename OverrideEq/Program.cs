using System;

namespace OverrideEq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer c = new Customer();
            c.FirstName = "Athulya";
            c.LastName = "Kumar";

            Customer c1 = new Customer();
            c1.FirstName = "Athulya";
            c1.LastName = "Kumar1";

            c.Equals(c1);
            Console.WriteLine(c.Equals(c1));

            var hashcodeC = c.GetHashCode();
            Console.WriteLine(hashcodeC);

            var hashcodeC1 = c1.GetHashCode();
            Console.WriteLine(hashcodeC1);

        }
    }

    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Customer)
             || this.FirstName != ((Customer) obj).FirstName
             || this.LastName != ((Customer)obj).LastName
            )
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
