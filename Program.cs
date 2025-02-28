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

            List<Person> people = new List<Person>
            {
                new Person("Alice", 25),
                new Person("Jack", 20),
                new Person("Ray", 56),
                new Person("Charlie", 28),
                new Person("David", 40)
            };

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
        }
    }
}
 