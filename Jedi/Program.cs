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
            nameAge[ "Han"] = 26;
            nameAge["Old"] = 100;
            nameAge["Name"] = 50;
            Console.WriteLine(nameAge.First());  

            nameAge.Remove("Han");       //Opgave 3

            foreach (var item in nameAge)   //Opgave 4
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
