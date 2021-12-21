using System;

namespace recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recursive 
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;

            }
            Console.WriteLine(result);
            Calculations instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // Extension
            string text = "Oguz Demir ";

            bool resultSpaces = text.CheckSpaces();

            Console.WriteLine(resultSpaces);

            if(resultSpaces){
                Console.WriteLine(text.RemoveWhiteSpaces());
            }
            Console.WriteLine(text.MakeLowerCase());
            Console.WriteLine(text.MakeUpperCase());

            int[] seriExample = {1,2,5,4,8,7,9,21,11};
            seriExample.SortArray();
            seriExample.PrintScreen();

            int number1 = 4;
            if(number1.IsEvenNumber()){
                Console.WriteLine("{0} is an even number", number1);
            }

            Console.WriteLine(text.GetFirstChar());
        }
    }

    public class Calculations 
    {
        public int Expo(int number, int exp){
            // if(exp == 0){
            //     return 1;
            // }

            if(exp<2){
                return number;
            }
            return number * Expo(number, exp - 1);
        }
    }

     // Extension class and methods should be static

        public static class Extension{

            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                string[] serie = param.Split(" ");
                return string.Join("", serie);
            }
            public static string MakeUpperCase(this string param)
            {
                return param.ToUpper();
            }
            public static string MakeLowerCase(this string param)
            {
                return param.ToLower();
            }

            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }

            public static void PrintScreen(this int[] param)
            {
                foreach (var item in param)
                {
                    Console.WriteLine(item);
                }
                
            }
            public static bool IsEvenNumber(this int param)
            {
                return param % 2 == 0;
            }
            public static string GetFirstChar(this string param)
            {
                return param.Substring(0,1);
            }
        }
}
