using System;

namespace inheritance
{
    public class Plants:LivingCreatures
    {
      public void Photosynthesise(){
          Console.WriteLine("Living creatures photosynthesise.");
        }
    }
    public class SeedPlants:Plants
    {
      public void ReproductionWithSeeds(){
        Console.WriteLine("Seed plants use seeds for reproduction.");
      } 
    }

    public class SeedlessPlants:Plants
    {
      public void ReproductionWithSpore(){
        Console.WriteLine("Seed plants use spores for reproduction.");
      } 
    }
}