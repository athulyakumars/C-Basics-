using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://date.nager.at/");
                var url = string.Format("api/v2/PublicHolidays/{0}/{1}", 2022, "US");
                var response = await client.GetAsync("url");
                if(response.IsSuccessStatusCode)
                {
                    var resp = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Hello World!" + resp);
                }
            }
            return 1;

        }
    }
}
