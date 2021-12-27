using System;

namespace inheritance
{
    public class Animals:LivingCreatures
    {
      protected void Adaptation(){
          Console.WriteLine("Living creatures Excretion");
        }
    }

    public class Reptiles:Animals
    {
      public Reptiles(){
        base.Adaptation();
        base.Breathe();
        base.Excrete();
        base.Feed();
        
      }
      public void ReptileMovement(){
        Console.WriteLine("Reptile Movement");
      }
    }
    public class  Birds:Animals
    {
      public Birds(){
        base.Adaptation();
        base.Breathe();
        base.Excrete();
        base.Feed();
      }
      public void Fly(){
        Console.WriteLine("Birds fly");
      }
    }
}