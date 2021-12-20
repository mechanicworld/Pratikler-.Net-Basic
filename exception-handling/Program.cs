using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number is : " + number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Process is done!");
            }

            try
            {
                //  int a = int.Parse(null);
                //  int b = int.Parse("test");
                 int c = int.Parse("-12345678910");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Null Value ");
                Console.WriteLine(ex);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data type is not okey ");
                Console.WriteLine(ex);
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow, too small or too large value  ");
                Console.WriteLine(ex);
                
            }
            finally
            {
            Console.WriteLine("Process is done!");
            }
           
        }
    }
}
