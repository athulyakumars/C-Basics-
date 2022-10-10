using System;

namespace C_Basics_Enums
{
    class Enums
    {
        public enum DayofWeeks
        {
            Sun,
            Mon = 10,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sunday: {0} ", (int)Enums.DayofWeeks.Sun);
            Console.WriteLine("Monday: {0} ",(int)Enums.DayofWeeks.Mon);
            Console.WriteLine("Tuesday: {0} ", (int)Enums.DayofWeeks.Tue);
        }
    }
}
