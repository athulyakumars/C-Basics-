using System;

namespace CalculatorOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator c = new Calculator(10,20);
            Console.WriteLine(c.Add());
        }
    }

    public abstract class Calc
    {
        public double No1 { get; set; }

        public double No2 { get; set; }

        public Calc(double no1, double no2)
        {
            this.No1 = no1;
            this.No2 = no2;
        }

        public abstract double Add();


    }

    public class Calculator : Calc
    {
        public Calculator(double no1, double no2): base(no1, no2)
        {

        }
        public override double Add()
        {
            return No1 + No2;
        }
    }
}
