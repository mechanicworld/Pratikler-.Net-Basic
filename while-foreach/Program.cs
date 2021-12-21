using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While 

            Console.WriteLine("Enter a number");
            int number = Int32.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0 ;
            while(counter <= number)
            {
                sum += counter;
                counter ++;

            }
            Console.WriteLine(sum/number);

            char character = 'a';
            while (character < 'z'){
                Console.WriteLine(character);
                character ++;
            }

            Console.WriteLine("Foreach");
            string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach(var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
