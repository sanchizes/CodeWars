using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class CountSheeps
    {
        public static string SheepsCount(int n)
        {
            //return new StringBuilder().Append("1 sheep").ToString();
            StringBuilder sb = new StringBuilder();
            byte count = 1;

            while (n > 0)
            {
                
                sb.Append($"{count} sheep...");
                count++;
                n--;
            }
            return sb.ToString();
        }
    }
}
