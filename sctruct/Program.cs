using System;

namespace sctruct
{
    class Program
    {
        static void Main(string[] args)
        {
          Rectangle rectangle = new Rectangle();
          rectangle.ShortSide= 4;
          rectangle.LongSide = 5;
          Console.WriteLine("Class*****");
          Console.WriteLine(rectangle.Area());

          Rectangle_Struct rectangle_struct = new Rectangle_Struct();
          // We can also use;
          // Rectangle_Struct rectangle_struct; without new this has not got initial values like class 
          rectangle_struct.ShortSide = 5;
          rectangle_struct.LongSide = 6;
           Console.WriteLine("Struct*****");
          Console.WriteLine(rectangle_struct.Area());

          Rectangle_Struct rectangle_struct_2 = new Rectangle_Struct(4,5);
          rectangle_struct_2.Area();




        }
    }

    class Rectangle
    {
        public int ShortSide;
        public int LongSide;

        public long Area()
        {
            return this.ShortSide * this.LongSide;
        }

    }

    struct Rectangle_Struct
    {
        public int ShortSide;
        public int LongSide;

        // Parametresiz COnstructor yapisina izin verilmez fakat parametre ile kullanabiliriz;
        
        public Rectangle_Struct(int shortSide, int longSide)
        {
            ShortSide = shortSide;
            LongSide = longSide;

        }
        public long Area()
        {
            return this.ShortSide * this.LongSide;
        }
    }
}
