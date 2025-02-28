using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override int GetArea()
        {
            return Convert.ToInt32(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
