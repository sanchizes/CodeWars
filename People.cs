using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    abstract class People
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating some food!");
        }
    }

    class Student : People
    {
        public override void Eat()
        {
            base.Eat();
        }
    }
}
