using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Box<T>
    {
        public T Value { get; set; }
        public string Equipment { get; set; }
        public Box(T value, string equipment)
        {
            Value = value;
            Equipment = equipment;
        }

        public void SetValue(T newValue)
        {
            Value = newValue;
        }

        public T GetValue()
        {
            return Value;
        }

        public void PrintType(T value)
        {
            Console.WriteLine(value?.GetType());
        }
    }
}
