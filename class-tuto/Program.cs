using System;

namespace class_tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                class ClassName
                {
                    [Access  Modifiers] [Data Type] PropName;
                    [Access Modifiers] [Return Type] MethodName[Parameters]{
                        // Method Commands
                    }
                }
            
            */

            // Access Modifiers
            // Public - anywhere
            // Private - 
            // Internal-Inside of a project
            // Protected -  In a class and inhrated class that was described

            Worker worker1 = new Worker();
            worker1.name="Oguz";
            worker1.surname="Demir";
            worker1.no=12345678;
            worker1.department= "Educational Improvement";
            worker1.WorkerInfo();
            Console.WriteLine("========");

             Worker worker2 = new Worker();
            worker2.name="Ahmet";
            worker2.surname="Ozcan";
            worker2.no=12345679;
            worker2.department= "Educational Improvement";
            worker2.WorkerInfo();
        }
    }

    class Worker
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public void WorkerInfo()
        {
            Console.WriteLine("Worker Name: {0}", name);
            Console.WriteLine("Worker Surname: {0}", surname);
            Console.WriteLine("Worker No: {0}", no);
            Console.WriteLine("Worker Departmant: {0}", department);
        }
    }
}
