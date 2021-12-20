using System;

namespace for_loop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a value for loop");
      int number = Int32.Parse(Console.ReadLine());
      for (int i = 0; i < number; i++)
      {
        if (i % 2 == 1)
        {
          Console.WriteLine(i);
        }

      }

      int sumOdd = 0;
      int sumEven = 0;


      for (int i = 0; i <= 1000; i++)
      {
        if (i%2 == 1)
        {
          sumOdd += i;
        }
        else
        {
          sumEven += i;
        }
      }

      Console.WriteLine("Sum of odd numbers: " + sumOdd);
      Console.WriteLine("Sum of even numbers: " + sumEven);


    // break, continue

    for (int i = 1; i < 10; i++)
    {
        if(i==4)
          break;
        Console.WriteLine(i);
    }

    for (int i = 1; i < 10; i++)
    {
        if(i==4)
          continue;
        Console.WriteLine(i);
    }


    }
  }
}
