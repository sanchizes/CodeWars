using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class PositiveCounter
    {
        public static int Counter(List<int> numbers) => numbers.Where(p => p > 0).Count();
    }
}
