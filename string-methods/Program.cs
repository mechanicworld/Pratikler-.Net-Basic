using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are learning C# yeah!";
            string text2 = "We are LearninG C# YEAH!";

            //Length
            Console.WriteLine("Length");
            Console.WriteLine(text.Length);

            //ToUpper & ToLower
            Console.WriteLine("ToUpper & ToLower");
            Console.WriteLine(text.ToLower()); 
            Console.WriteLine(text.ToUpper()); 

            //Concat
            Console.WriteLine("Concat");
            Console.WriteLine(String.Concat(text," !!Helloa"));

            // Compare, CompareTo
            Console.WriteLine("Compare, CompareTo");
            Console.WriteLine(text.CompareTo(text2)); // 0 equal , 1 greater ,-1  smaller length
            Console.WriteLine(String.Compare(text, text2, true)); // true ignore case sensitive
            Console.WriteLine(String.Compare(text, text2, false)); // false ignore case sensitive

            //Contains
            Console.WriteLine("Contains");
            Console.WriteLine(text.Contains(text2));
            Console.WriteLine(text.EndsWith("yeah!"));
            Console.WriteLine(text.StartsWith("We"));

            // IndexOf
            Console.WriteLine("IndexOf");
            Console.WriteLine(text.IndexOf("are"));
            Console.WriteLine(text.IndexOf("no"));

            // Insert
            Console.WriteLine("Insert");
            Console.WriteLine(text.Insert(0, "Hello! "));

            //LastIndexOf
            Console.WriteLine("LastIndexOf");
            Console.WriteLine(text.LastIndexOf("a"));

            // PadLeft, PadRight
            Console.WriteLine("PadRight&Left");
            Console.WriteLine(text + text2.PadLeft(45,'*'));
            Console.WriteLine(text + text2.PadRight(45,'*'));

            // Remove
            Console.WriteLine("Remove");
            Console.WriteLine(text.Remove(11,3));
            Console.WriteLine(text.Remove(10));

            //Replace
            Console.WriteLine("Replace");
            Console.WriteLine(text.Replace("are", "&&&"));

            // Split
            Console.WriteLine("Split");
            Console.WriteLine(text.Split(" ")[1]);

            // Substring
            Console.WriteLine("Substring");
            Console.WriteLine(text.Substring(4));
            Console.WriteLine(text.Substring(4,6));





        }
    }
}
