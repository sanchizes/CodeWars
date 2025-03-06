using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Bike : Vehicle
    {
        public string Weight { get; set; }
        public Bike(int speed, string weight) : base()
        {
            Speed = speed;
            Weight = weight;
        }
        public override void Move()
        {
            Console.WriteLine($"Bike is moving at speed {Speed}");
        }
    }
}
