using System;

namespace operators
{
  class Program
  {
    static void Main(string[] args)
    {
      // 
      int x = 3;
      int y = 3;
      y = y + 2;
      Console.WriteLine(y);
      y += 2;
      Console.WriteLine(y);
      y *= 3;
      Console.WriteLine(y);

      // Logical Operators
      Console.WriteLine("Logical  operators");

      bool isSuccess = true;
      bool isCompleted = false;

      if (isSuccess && isCompleted)
      {
        Console.WriteLine("Perfect");
      }
      if (isSuccess && isCompleted)
      {
        Console.WriteLine("Perfect!");
      }
      if (isSuccess || isCompleted)
      {
        Console.WriteLine("Great!");
      }
      if (isSuccess && !isCompleted)
      {
        Console.WriteLine("Fine!");
      }

      // Relational Operators 
      // < , > , <= , >= , == , !=
      Console.WriteLine("Relartional operators");

      int a = 3;
      int b = 4;
      bool resultCheck = a < b;
      Console.WriteLine(resultCheck);
      resultCheck = a > b;
      Console.WriteLine(resultCheck);
      resultCheck = a == b;
      Console.WriteLine(resultCheck);
      resultCheck = a != b;
      Console.WriteLine(resultCheck);


      // Arithmetic Operators 
      // - , + , = , / , *, %
      Console.WriteLine("Arithmetic operators");
      int number1 = 10;
      int number2 = 2;
      int resultNumber = number1 + number2;
      Console.WriteLine(resultNumber);
      resultNumber = number1 - number2;
      Console.WriteLine(resultNumber);
      resultNumber = number1 * number2;
      Console.WriteLine(resultNumber);
      resultNumber = number1 / number2;
      Console.WriteLine(resultNumber);
      resultNumber = ++number1;
      Console.WriteLine(resultNumber);
      // ++ sayi oncesi gelirse islem sonrasi degeri yazar sagina yazilirisa islem oncesi degeri yazar

      // % 
      int number3 = 20;
      int resultMod = number3 % 3;
      Console.WriteLine(resultMod);

    }
  }
}
