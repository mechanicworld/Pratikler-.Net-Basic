
using System;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      SeedPlants seedPlant1 = new SeedPlants();
   
      seedPlant1.ReproductionWithSeeds();

      Birds seagull = new Birds();
      
      seagull.Fly();

    }
  }
}