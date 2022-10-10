using System;

namespace DelegateDemo
{
    public delegate bool CustomerDelegate(Customer customer);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cust = new Customer()
            {
                Id = 123,
                Name = "Athulya",
                Salary = 15000,
                LastThreeMonthTransaction = 45000
            };
            //Customer.IsEligibleForLoan(cust); // IsEligibleForLoan method is static. Thats why used class name
            CustomerDelegate cd = new CustomerDelegate(Approve);
            //Customer.IsEligibleForLoan(cust, cd);
            Customer.IsEligibleForLoan(cust, cust => cust.Salary > 10000 && cust.LastThreeMonthTransaction > 30000);
        }

        public static bool Approve(Customer cust)
        {
            if(cust.Salary > 10000 && cust.LastThreeMonthTransaction > 30000)
            {
                return true;
            }
            return false;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public int LastThreeMonthTransaction { get; set; }
        public string Name { get; set; }

        public static void IsEligibleForLoan(Customer c, CustomerDelegate cd)
        {
            if(cd(c))
            {
                Console.WriteLine("Loan Approved");
            }
        }
    }
}
