using System;

namespace inheritance
{
  public class Plants : LivingCreatures
  {
    protected void Photosynthesise()
    {
      Console.WriteLine("Living creatures photosynthesise.");
    }
  }
  public class SeedPlants : Plants
  {
    public SeedPlants()
    {
      base.Photosynthesise();
      base.Breathe();
      base.Excrete();
      base.Feed();

    }
    public void ReproductionWithSeeds()
    {
      Console.WriteLine("Seed plants use seeds for reproduction.");
    }
  }

  public class SeedlessPlants : Plants
  {
    public SeedlessPlants()
    {
      // For protected structure we need to add base method to 
      // vhild class to be reached 
      base.Photosynthesise();
      base.Breathe();
      base.Excrete();
      base.Feed();
    }
    public void ReproductionWithSpore()
    {
      Console.WriteLine("Seed plants use spores for reproduction.");
    }
  }
}