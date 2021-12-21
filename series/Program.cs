using System;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string[] colors = new string[5];
        //    string[] animals = {"Cat", "Dog", "Bird", "Monkey"};

        //    int[] serieNumber;
        //    serieNumber = new int[5];

           // Asign values to series and indexing

        //    colors[0] = "Mavi";
        //    serieNumber[3] = 10;
        //    Console.WriteLine(animals[1]);
        //    Console.WriteLine(serieNumber[3]);
        //    Console.WriteLine(colors[0]);

           // Series with Loops
           Console.WriteLine("Enter a value for serie length");
           int serieLength = Int32.Parse(Console.ReadLine());
           int[] numberSeries = new int[serieLength];

           for (int i = 0; i < serieLength ; i++)
           {
               Console.WriteLine("Please enter value {0} ", i+1);
               numberSeries[i] = Int32.Parse(Console.ReadLine());
           } 

            int sumOfSerie = 0 ;
           foreach( var number in numberSeries){
               sumOfSerie += number;
           }
            Console.WriteLine("Average: {0} ", sumOfSerie/serieLength);

        }
    }
}
