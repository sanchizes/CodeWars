using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class IntListToString
    {
        public static List<string> ToStringList(List<int> ints) => ints.Select(el => $"Число: {el}").ToList();
    }
}
