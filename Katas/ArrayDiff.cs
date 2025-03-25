using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class ArrayDiff
    {
        public static int[] Diff(int[] a, int[] b)
        {
            List<int> ints = a.ToList();

            if (b.Length == 0) return a;
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    int elementOfB = b[i];

                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == elementOfB)
                        {
                            ints.Remove(a[j]);
                        }
                    }
                }
            }

            return ints.ToArray();
        }
    }
}
