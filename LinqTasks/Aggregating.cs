using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class Aggregating
    {
        public static List<int> GetSpecificSalaries(List<int> salaries)
        { 
            salaries.Add(salaries.Min());
            salaries.Add((int)salaries.Average());
            salaries.Add(salaries.Max());
            salaries.RemoveRange(0, salaries.Count - 3);
            return salaries;
        }
    }
}
