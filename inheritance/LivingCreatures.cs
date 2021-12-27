
using System;

namespace inheritance
{
    public class LivingCreatures
    {
        protected void Feed(){
          Console.WriteLine("Living creatures feed");
        }

        protected void Breathe(){
          Console.WriteLine("Living creatures breathe");
        }

        protected void Excrete(){
          Console.WriteLine("Living creatures Excretion");
        }
    }
}