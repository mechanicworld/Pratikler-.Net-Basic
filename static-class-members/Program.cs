using System;

namespace static_class_members
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Number of Employee : {0}", Employee.NumberOfEmployee);
           Employee employee1 = new Employee("Oguz", "Demir", "Developer");
           Console.WriteLine("Number of Employee : {0}", Employee.NumberOfEmployee);
           

           Console.WriteLine("Sum :{0}", Calculations.Sum(50,23));
           Console.WriteLine("Sum :{0}", Calculations.Subtraction(50,23));
        }
    }

    class Employee 
    {
        private static int numberOfEmployee;
        public static int NumberOfEmployee { get => numberOfEmployee; }

        private string name;
        private string surname;
        private string departmant;

        static Employee(){
            numberOfEmployee = 0;
        }
        public Employee(string name, string surname, string departmant)
        {
            this.name = name;
            this.surname = surname;
            this.departmant = departmant;
            numberOfEmployee ++;
        }

    }

    static class Calculations
    {
        public static long Sum (int number1, int number2)
        {
            return number1 + number2;
        }

        public static long Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
