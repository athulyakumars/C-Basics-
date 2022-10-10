using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace AsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASync Method call");
            var result1 = Method1Async(10);

            Console.WriteLine("Sync Method call");
            
            var result = Method1(10);
            Console.WriteLine("Sync Method Call Result" + result);
            Console.WriteLine("Async Method Call Result" + result1.Result);
        }

        private static int Method1(int count)
        {
            int result = 0;
            for (int i = 0; i <= count; i++)
            {
                Thread.Sleep(200);// 200 millisecond
                Console.WriteLine("Async Print Number " + i);
                result += i;
            }
            return result;
        }

        private static Task<int> Method1Async(int count)
        {
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 0; i <= count; i++)
                {
                    Thread.Sleep(200);// 200 millisecond
                    Console.WriteLine("Sync Print Number " + i);
                    result += i;
                }
                return result;
            });
            task.Start();
            return task;
        }

        private async Task<string> Local()
        {
            Console.WriteLine("Async File Read...");
            string text = await File.ReadAllTextAsync("abc.txt");
            Console.WriteLine("Async File Read... "+ text);
            return text;
        }
    }
}
