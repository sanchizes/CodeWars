using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ListPractice
{
    internal class BasicMethods
    {
        //-----------------
        //1
        public static void ListAddItem(List<string> list, string newItem) => list.Add(newItem);
        public static void ListAddItems(List<string> list, List<string> newItems) => list.AddRange(newItems);
        public static void ListAddGenericsType<T>(List<T> list, List<T> genericItems) => list.AddRange(genericItems);

        //-----------------
        //2


    }
}
