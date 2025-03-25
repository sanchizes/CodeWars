using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class StringRepeat
    {
        public static string RepeatMethod(int n, string s)
        {
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += s;
            }
            return res;
        }
    }
}
