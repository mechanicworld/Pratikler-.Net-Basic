using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keys should be uniq compile time do not throw any exception in run time wee get error
            // System.Collection.Generic

            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(10, "Oguz Demir");
            users.Add(12,"Ilayda Demir");
            users.Add(9,"Mustafa Can");
            users.Add(11,"Ahmet Mehmet");

            // Get items from dictionary
            Console.WriteLine("Get Item from Dictionary***");
            Console.WriteLine(users[10]);

            foreach(var item in users){
                Console.WriteLine(item);
            }
            // Count
            Console.WriteLine("Count***");
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine("Cotains***");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Oguz Demir"));

            // Remove
            Console.WriteLine("Remove***");
            users.Remove(9);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            // Keys
            Console.WriteLine("Keys***");
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }

            // Values
            Console.WriteLine("Values***");
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }





        }
    }
}
