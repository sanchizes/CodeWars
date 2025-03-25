using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class AscendingList
    {
        public static List<int> ListFormat(List<int> list)
        {
            List<int> formattedList = new List<int>();
            for (int i = list[0]; i < list.Count; i++)
            {
                formattedList.Add(i);
            }
            return formattedList;
        } 
    }
}
