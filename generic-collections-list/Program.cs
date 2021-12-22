using System;
using System.Collections.Generic;

namespace generic_collections_list
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<T> class
           // System.Collections.Generic

           // T means generic, T is an object type

           List<int> numberList = new List<int>();
           numberList.Add(23);
           numberList.Add(2);
           numberList.Add(33);
           numberList.Add(53);
           numberList.Add(4);

           List<string> colorList = new List<string> ();
           colorList.Add("Red");
           colorList.Add("Blue");
           colorList.Add("Orange");
           colorList.Add("Yellow");
           colorList.Add("Green");

           Console.WriteLine(colorList);
           

           // Count
           Console.WriteLine(colorList.Count);
           Console.WriteLine(numberList.Count);

            // Loop items
           foreach(var item in numberList){
               Console.WriteLine(item);
           }

           colorList.ForEach( item => Console.WriteLine(item));
           
           // Remove
           numberList.Remove(4);
           numberList.RemoveAt(0);
           numberList.ForEach(x => Console.WriteLine(x));

           // Search in List
            if(numberList.Contains(2)){
                Console.WriteLine("2 find in list");
            }

            // Get index with item in list#
            Console.WriteLine(colorList.BinarySearch("Red"));

            // Convert array to list
            string[] animals = {"Cat", "Dog", "Bird"};
            List<string> animalsList = new List<string>(animals);
            
            // Clear all list
            animalsList.Clear();

            // Object keep in list#
            List<Users> userList = new List<Users>();

            Users user1 = new Users();
            user1.Age = 28;
            user1.Name = "Oguz";
            user1.Surname = "Demir";

            Users user2 = new Users();
            user2.Age = 28;
            user2.Name = "Ilayda";
            user2.Surname = "Demir";

            userList.Add(user1);
            userList.Add(user2);
            List<Users> newUsers = new List<Users>();
            newUsers.Add(new Users(){
                Name= "Ahmet",
                Surname="Ozturk",
                Age=29
            });

            foreach( var user in userList){
                Console.WriteLine(user.Name + user.Surname + user.Age);
            }
        }
    }

    public class Users{
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

    }
}
