using CodeWars.Katas;
using CodeWars.LinqTasks;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace CodeWars
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> strings = new List<string> { "word", "sun", "Oleksandr" };

            var myGame = new Games("Dota 2", 2012);
            myGame.Hours = 3000;
            //Console.WriteLine(myGame.Hours);

            Random random = new Random();
            int randomNumber = random.Next(1, 5);
        }

        enum MonthOfYear
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }   

            List<int> nums = new List<int> { -1, -15, 0, 55, -2 };

            GroupItems.GetGrouped(people);
            foreach(var item in people)
            {
                Console.WriteLine(item.Age);
            }

            List<Orders> orders = new List<Orders>
            {
                new Orders{Id = 1, Items = new List<string>{"bottle", "cup"}},
                new Orders{Id = 2, Items = new List<string>{"book", "glasses"}}
            };

            foreach(var i in NestedCollections.ItemsFromOrders(orders))
            {
                Console.WriteLine(i);
            }

            List<int> salaries = new List<int> { 400, 100, 300, 1100 };

            foreach(var i in Aggregating.GetSpecificSalaries(salaries))
            {
                Console.WriteLine(i);
            }
        }
    }
}
 