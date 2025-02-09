using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class AnagramDetection
    {
         public bool IsAnagram(string input, string original)
        {
            return input.ToLower().OrderBy(s => s).SequenceEqual(original.ToLower().OrderBy(s => s));
        }
    }
}
