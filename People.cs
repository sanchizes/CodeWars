using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class People
    {
        public string Name { get; set; }
        int Age { get; set; }
        //Gender Gender { get; set; }

        public People( string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
        }

        public enum Gender
        {
            Man = 1,
            Woman = 2,
            Other = 0

        }
    }
}
