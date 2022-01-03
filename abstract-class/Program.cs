using System;

namespace abstract_class
{
  class Program
  {
    static void Main(string[] args)
    {
      Focus focus = new Focus();
      Console.WriteLine(focus.WhichBrand().ToString());
      Console.WriteLine(focus.HowManyWheels().ToString());
      Console.WriteLine(focus.StandartColor().ToString());
      Console.WriteLine("--------------------------\n");
      Civic civic = new Civic();
      Console.WriteLine(civic.WhichBrand().ToString());
      Console.WriteLine(civic.HowManyWheels().ToString());
      Console.WriteLine(civic.StandartColor().ToString());
      Console.WriteLine("--------------------------\n");
      NewFocus focus2 = new NewFocus();
      Console.WriteLine(focus2.WhichBrand().ToString());
      Console.WriteLine(focus2.HowManyWheels().ToString());
      Console.WriteLine(focus2.StandartColor().ToString());
      Console.WriteLine("--------------------------\n");
      NewCivic civic2 = new NewCivic();
      Console.WriteLine(civic2.WhichBrand().ToString());
      Console.WriteLine(civic2.HowManyWheels().ToString());
      Console.WriteLine(civic2.StandartColor().ToString());
      Console.WriteLine("--------------------------\n");
    }
  }
}
