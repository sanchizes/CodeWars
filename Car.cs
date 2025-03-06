using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Car : Vehicle
    {
        public int Price { get; set; }

        public Car(int speed, int price) : base()
        {
            Speed = speed;
            Price = price;
        }

        public override void Move()
        {
            Console.WriteLine($"Car is moving at speed {Speed}");
        }
    }
}
