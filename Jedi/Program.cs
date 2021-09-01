using System;
using System.Linq;
using System.Collections.Generic;

namespace Jedi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAge = new Dictionary<string, int>() { };     //Opgave 1
            nameAge.Add("Jannick", 21);      //Opgave 2
            nameAge.Add("Name", 50);
            nameAge.Add("Han", 28);
            nameAge.Add("Old", 100);
            Console.WriteLine(nameAge.First());  

            nameAge.Remove("Han");       //Opgave 3

            foreach (var item in nameAge)   //Opgave 4
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
