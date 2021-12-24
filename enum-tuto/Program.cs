using System;

namespace enum_tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Friday);
            Console.WriteLine(Days.Monday);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine((int) Days.Friday);

            int weatherState = 32;

            if(weatherState < (int)Weather.Normal){
                Console.WriteLine("A litt");
            }
        }

        enum Days{
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Weather{
            Cold = 5,
            Normal = 20,
            Hot = 26,
            TooHot = 32
        }
    }
}
