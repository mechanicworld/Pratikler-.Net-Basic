using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
          int time = DateTime.Now.Hour;

          if(time <= 12){
            Console.WriteLine("Good moorning!");
          }
          else if(time <= 16){
              Console.WriteLine("Good afternoon!");
          }
          else if( time <= 22){
            Console.WriteLine("Good evening!");
          }
          else {
            Console.WriteLine("Good Night");
          };

         string result = time >= 6 && time < 11 
                                                ? "Good Morning"
                                                : time >=11 && time < 16 
                                                  ?"Good Afternoon"
                                                  : time>=16 && time< 22 
                                                    ? "Good Evening"
                                                    : "Good Night";
        Console.WriteLine(result + time);

        }
    }
}
