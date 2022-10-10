using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            Console.WriteLine("Hello World!");
            List<int> elements = new List<int> { 10, 3, 5, 6, 14 };
            int[] myNumbers = { 5, 1, 8, 9 };
            //Console.WriteLine(Array.BinarySearch(myNumbers,10));
            elements.Add(50);
            Console.WriteLine("List of numbers");
            watch.Start();
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
            watch.Stop();
            Console.WriteLine("Execution Time " + watch.ElapsedMilliseconds);
            Console.WriteLine($"Execution Time Data {watch.ElapsedMilliseconds}");
            elements.MySort();
            Console.WriteLine("Sorted List");
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static class MyListFunction
    {
        public static void MySort(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    int temp;
                    if(list[i] < list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}
