using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
          // 

          Methods example = new Methods();

          int a = 1;
          int b = 2;
          int result = SumUp(a,b);
          int result2 = example.IncreseAndSum(a,b);  
          Console.WriteLine("a:{0}, b:{1}", a,b);     
          int result3 = example.IncreseAndSumRef(ref a, ref b); 
          // With references , original values was changed
          Console.WriteLine("a:{0}, b:{1}", a,b);        

          
          example.PrintToScreen(result.ToString());
          example.PrintToScreen(result2.ToString());
          example.PrintToScreen(result3.ToString());
          
        }

        static public int SumUp(int value1, int value2)
        {
            return value1 + value2;
        }
    }

    class Methods{

        public void PrintToScreen(string data){
            Console.WriteLine(data);
        }

        public int IncreseAndSum(int value1, int value2){
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
         public int IncreseAndSumRef(ref int value1,ref int value2){
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
    }
}
