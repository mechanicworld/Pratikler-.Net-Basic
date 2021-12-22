using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList newList = new();
           newList.Add("Oguz");
           newList.Add(true);
           newList.Add(3);

           // Index
           Console.WriteLine(newList[1]);

           foreach(var item in newList){
               Console.WriteLine(item);
           }

           // AddRange
           Console.WriteLine("Add Range***");

           string[] colors = {"red", "blue", "green"};

           List<int> numbers = new List<int>(){1,3,4,2,8,7,9,6};
           newList.AddRange(colors);
           newList.AddRange(numbers);

           // Sort
           Console.WriteLine("Sort***");
           //    newList.Sort();
            ArrayList numbersArray = new ArrayList();
            numbersArray.AddRange(numbers);
            numbersArray.Sort();
            
            foreach (var item in numbersArray)
            {
                Console.WriteLine(item);                
            }

            // Binary Search must be use in a sorted list
            Console.WriteLine("Binary Search ***");
            Console.WriteLine(numbersArray.BinarySearch(9));

            // Reverse
            Console.WriteLine("Reverse***");

            numbersArray.Reverse();
            foreach(var item in numbersArray){
              Console.WriteLine(item);
            }
            // Clear
            Console.WriteLine("Clear***");
            numbersArray.Clear();
            foreach(var item in numbersArray){
              Console.WriteLine(item);
            }

        }
    }
}
