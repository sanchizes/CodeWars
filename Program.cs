using CodeWars.Katas;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace CodeWars
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var myBook = new Book("1984", "George Orwell", 1949);
            myBook.Title = "Animal Farm";
            //Console.WriteLine(myBook.Title);

            var myGame = new Games("Dota 2", 2012);
            myGame.Hours = 3000;
            //Console.WriteLine(myGame.Hours);

            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            People first_patient = new People("Teo", 24, People.Gender.Man);
            Console.WriteLine(first_patient.Name);

            Box<int> box1 = new Box<int>(545, "Nothing");
            Box<string> box2 = new Box<string>("Twenty eight", "Something");

            int num = box1.GetValue();
           
            Console.WriteLine(num);

            box1.SetValue(12);
            Console.WriteLine(box1.Value);
            box1.PrintType(box1.Value);

            Console.WriteLine(CompareValues(12, 12));
            Console.WriteLine(CompareValues("str", "new"));

            Console.WriteLine(RemoveAnchor.RemoveUrlAnchor("www.codewars.com/katas/?page=1"));

            Console.WriteLine(AscendingList.ListFormat({1,2,3,5,6,8,9}));
                
        }

        static bool CompareValues<T>(T value1, T value2)
        {
            return Object.Equals(value1, value2);
        }

        enum MonthOfYear
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }   

        enum TypeOfCar
        {
            Sedan,
            Coupe,
            Hatchback,
            Track
        }

        static string SwitchResult(MonthOfYear monthOfYear)
        {
            switch (monthOfYear)
            {
                case MonthOfYear.January:
                    return "first month";
                case MonthOfYear.February:
                    return "second month";
                case MonthOfYear.March:
                    return "Wednesday";
                case MonthOfYear.April:
                    return "Thursday";
                default:
                    return "Idi nahuy, suka blyat!";
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public bool IsAvailable { get; set; } = true;

            public Book(string title, string author, int year)
            {
                Title = title;
                Author = author;
                Year = year;
            }
        }

        class Games
        {
            private string Name;

            private int hours;
            public int Hours
            {
                get { return hours; }
                set { hours = value; }
            }

            private int _year;

            public Games(string name, int year)
            {
                Name = name;
                _year = year;
            }

        }

    }
}
 