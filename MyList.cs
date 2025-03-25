using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class MyList<T>
    {
        public T Array { get; set; }
        
        public MyList(T value)
        {
            Array = value;
        }

        static void Add(T value)
        {
        }
    }
}
