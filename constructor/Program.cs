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
            Console.WriteLine("\n============START============\n");
            Console.WriteLine("Worker 1");
            Worker worker1 = new Worker("Oguz","Demir",12345678,"Educational Improvement");            
            worker1.WorkerInfo();
            

            Console.WriteLine("Worker 2");
            Worker worker2 = new Worker();
            worker2.name="Ahmet";
            worker2.surname="Ozcan";
            worker2.no=12345679;
            worker2.department= "Educational Improvement";
            worker2.WorkerInfo();
            
            Console.WriteLine("Worker 3");
            Worker worker3 = new Worker("Suleyman", "Kahraman");            
            worker3.WorkerInfo();


            Console.WriteLine("\n=============END=============\n");
        }
    }

    class Worker
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public Worker(string name, string surname, int no , string departmant)
        {
            this.name = name;
            this.surname = surname;
            this.no = no ;
            this.department = departmant;
        }
        public Worker(){

        }
        public Worker(string name, string surname){
            this.name = name;
            this.surname = surname;
        }
        public void WorkerInfo()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Worker Name: {0}", name);
            Console.WriteLine("Worker Surname: {0}", surname);
            Console.WriteLine("Worker No: {0}", no);
            Console.WriteLine("Worker Departmant: {0}", department);
            Console.WriteLine("=========================\n");
            
        }
    }
}
