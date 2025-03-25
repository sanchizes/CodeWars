using CodeWars.Katas;
using CodeWars.LinqTasks;
using CodeWars.ListPractice;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace CodeWars
{


    internal class Program
    {
        //static void Main(string[] args)
        //{

        //}
        static async Task Main()
        {
            await ProcessDataAsync();
        }

        static async Task<string> FetchDataAsync(string source)
        {
            Random random = new Random();
            int delay = random.Next(1000, 3000);

            await Task.Delay(delay);

            return $"Data from {source}";
        }

        static async Task ProcessDataAsync()
        {
            List<Task<string>> tasks = new List<Task<string>>
            {
                FetchDataAsync("API"),
                FetchDataAsync("DataBase"),
                FetchDataAsync("File")

            };

            while (tasks.Count > 0)
            {
                Task<string> completedTask = await Task.WhenAny(tasks);
                tasks.Remove(completedTask);

                string result = await completedTask;
                Console.WriteLine(result);
            }
        }
    }
}
 