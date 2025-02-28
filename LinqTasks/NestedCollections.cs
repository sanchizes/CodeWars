using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LinqTasks
{
    internal class NestedCollections
    {
        public static List<string> ItemsFromOrders(List<Orders> orders) => orders.SelectMany(o => o.Items).ToList();
    }
}
