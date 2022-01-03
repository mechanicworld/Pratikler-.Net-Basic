using System;

namespace interface_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.HowManyWheels().ToString());
            Console.WriteLine(focus.StandartColor().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.WhichBrand().ToString());
            Console.WriteLine(civic.HowManyWheels().ToString());
            Console.WriteLine(civic.StandartColor().ToString());
        }
    }
}
