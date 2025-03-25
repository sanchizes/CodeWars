using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class FilterGeese
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            List<string> b = birds.ToList();
            foreach(var str in geese)
            {
                if (b.Contains(str))
                {
                    b.Remove(str);
                }
            }

            return b;
        }
    }
}
