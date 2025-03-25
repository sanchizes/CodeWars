using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CodeWars.Katas
{
    internal class SortArrayByLength
    {
        public static List<string> SortArrayMethod(List<string> array)// => new List<string>(strings).Order().ToArray();
        { 

            return array.Order().ToList();
        }
    }
}
