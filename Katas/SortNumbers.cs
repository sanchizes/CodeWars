using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class SortNumbers
    {
        public static int[] SortNums(int[]? intArray)
        {
            if (intArray != null)
            {
                Array.Sort(intArray);
                return intArray;
            }
            else return [];
        }
    }
}
