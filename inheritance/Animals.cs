using System;

namespace inheritance
{
    public class Animals:LivingCreatures
    {
      public void Adaptation(){
          Console.WriteLine("Living creatures Excretion");
        }
    }

    public class Reptiles:Animals
    {
      public void ReptileMovement(){
        Console.WriteLine("Reptile Movement");
      }
    }
    public class  Birds:Animals
    {
      public void Fly(){
        Console.WriteLine("Birdsd fly");
      }
    }
}