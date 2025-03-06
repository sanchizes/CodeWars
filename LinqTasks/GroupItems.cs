using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class GroupItems
    {
        public static List<Person> GetGrouped(List<Person> nums)
        {
            nums.GroupBy(p => p.Age < 30 && p.Age > 30);
            return nums;
        }
    }
}
