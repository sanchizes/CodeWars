using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class StrayNumber
    {
        //input:[ 17, 17, 3, 17, 17, 17, 17 ]
        public static int SingleReturner(int[] array)
        {
            //int different = 0;
            //foreach (var i in array)
            //{
            //    int temp = array[0];
            //    if (i != temp)
            //    {
            //        different = i;
            //        break;
            //    }
            //}
            //return different;
            Array.Sort(array);
            if (array[0] != array[1]) return array[0];
            else return array[array.Length - 1];

        }
    }
}
