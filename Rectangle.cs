using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override int GetArea()
        {
            return Height * Width;
        }
    }
}
