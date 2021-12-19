using System;

namespace variables
{
  class Program
  {
    static void Main(string[] args)
    {
      int value;


      byte b = 5;       // 1 byte
      sbyte sb = 5;      // 1 byte

      short s = 5;      // 2 byte
      ushort us = 5;    // 2 byte

      Int16 i16 = 2;    // 2 byte
      int i = 2;        // 4 byte
      Int32 i32 = 2;    // 4 byte
      Int64 i64 = 2;    // 8 byte

      uint ui = 2;      // 4 byte
      long l = 4;       // 8 byte
      ulong ul = 4;     // 8 byte

      // Reel sayilar
      float f = 5;     // 4 byte
      double d = 5;     // 8 byte
      decimal de = 5;   // 16 byte 

      char ch = '2';    // 2 byte
      string str = "Oguz"; // Limitless

      bool b1 = true;
      bool b2 = false;

      DateTime dt = DateTime.Now;

      Console.WriteLine(dt);

      object o1 = "x";
      object o2 = 'y';
      object o3 = 4;
      object o4 = 4.3;

      // string 

      string str1;
      string str2 = null;
      string str3 = string.Empty;
      str3 = "Oguz Demir";
      string name = "Oguz";
      string surName = "Demir";
      string fullId = name + " " + surName;

      // integers
      int int1 = 5;
      int int2 = 3;

      int int3 = int1 * int2;

      // boolean 

      bool bool1 = 10 < 2;
      bool bool2 = 10 > 2;

      // Variable Convertion 

      string str20 = "20";
      int int20 = 20;
      string newStr = str20 + int20.ToString();
      Console.WriteLine(newStr);

      int int21 = int20 + Convert.ToInt32(str20);
      Console.WriteLine(int21);

      int int22 = int20 + int.Parse(str20);
      Console.WriteLine(int22);

      // Datetime

      string datetime = DateTime.Now.ToString("dd.MM.yyyy");
      Console.WriteLine(datetime);
      string datetime2 = DateTime.Now.ToString("dd.MM.yyyy/HH:mm");
      Console.WriteLine(datetime2);
      
      
      

    }
  }
}
