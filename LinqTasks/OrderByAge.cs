using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class OrderByAge
    {
        public static List<Person> SortingByAge(List<Person> people) => people.OrderBy(p => p.Age).ToList();
    }
}
