using System;

namespace methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out parameters

            string number = "999";
            bool result = int.TryParse(number, out int outNumber);

            if(result){
                Console.WriteLine("Success");
                Console.WriteLine(outNumber);
            }else{
                Console.WriteLine("Fail");
            }

            Methods instance = new Methods();
            instance.SumUp(2,3, out int sumResult);

            // Method-Overloading

            int value = 999;
            instance.PrintToScreen(value.ToString());
            instance.PrintToScreen(value);
            instance.PrintToScreen(Convert.ToString(value), value.ToString());

            // Method sign  => Method Name + Parameter Count + Parameters  one of them should be changed to get
            // permission to overload a method


        }
    }

    class Methods 
    {
        public void SumUp(int a, int b , out int sum) 
        {
            sum = a+b;
        }
        public void PrintToScreen(string data){
            Console.WriteLine(data);
        }
        public void PrintToScreen(int data){
            Console.WriteLine(data);
        }
        public void PrintToScreen(string data1, string data2){
            Console.WriteLine(data1 + data2);
        }
    }
}
