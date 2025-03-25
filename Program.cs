using CodeWars.Katas;
using CodeWars.LinqTasks;
using CodeWars.ListPractice;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace CodeWars
{


    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in ArrayDiff.Diff([1,2], [1]))
            {
                Console.WriteLine(item);
            }

            FilterGeese.GooseFilter(["Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"]).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(StringRepeat.RepeatMethod(7, "suka"));

            foreach(var str in SortArrayByLength.SortArrayMethod(["", "Moderately", "Brains", "Pizza"]))
            {
                Console.WriteLine(str);
            }

            Thread myThread = new Thread(Output);

            myThread.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main thread: {i}");
            }

        }
        static void Output()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Secondary thread: {i}");
            }
        }
    }
}
 