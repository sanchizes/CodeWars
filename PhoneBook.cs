using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class PhoneBook
    {
        public static void NewNumber(Dictionary<int, string> phoneBook, int num, string name)
        {
            phoneBook.Add(num, name);
        }

    }
}
