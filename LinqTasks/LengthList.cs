using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class LengthList
    {
        public static List<int> FormLengthList(List<string> str) => str.Select(el => el.Length).ToList();
    }
}
