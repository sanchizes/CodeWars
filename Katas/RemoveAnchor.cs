using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class RemoveAnchor
    {
        public static string RemoveUrlAnchor(string url)
        {
            int index = url.IndexOf('#');
            return url.Substring(0, index);
        }
    }
}
