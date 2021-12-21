using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] numberSeries = {3,5,18,21,2,1,86,32};

            Console.WriteLine("***Unsorted");
            foreach( var number in numberSeries){
                Console.WriteLine("Number is : {0}", number);
            }

            // Array.Sort()
            Console.WriteLine("***Array.Sort()"); 
            Array.Sort(numberSeries);
            foreach( var number in numberSeries){
                Console.WriteLine("Number is : {0}", number);
            }

            // Array.Clear()
            Console.WriteLine("***Array.Clear()"); 

            Array.Clear(numberSeries,2,2);

             foreach( var number in numberSeries){
                Console.WriteLine(number);
            }

             // Array.Reverse()
            Console.WriteLine("***Array.Reverse()"); 

            Array.Reverse(numberSeries);
            foreach( var number in numberSeries){
                Console.WriteLine(number);
            }
            // Array.IndexOf()
            Console.WriteLine("***Array.IndexOf()"); 
            Console.WriteLine(Array.IndexOf(numberSeries, 86));

            // Array.Resize()
            Console.WriteLine("***Array.Resize()"); 

            Array.Resize<int>(ref numberSeries, 9);
            numberSeries[8] = 99;
            
            foreach( var number in numberSeries){
                Console.WriteLine(number);
            }




              
        }
    }
}
