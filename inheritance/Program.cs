using System;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      SeedPlants seedPlant1 = new SeedPlants();
      seedPlant1.Feed();
      seedPlant1.Breathe();
      seedPlant1.Excrete();
      seedPlant1.Photosynthesise();
      seedPlant1.ReproductionWithSeeds();

      Birds seagull = new Birds();
      seagull.Adaptation();
      seagull.Breathe();
      seagull.Excrete();
      seagull.Feed();
      seagull.Fly();

    }
  }
}
