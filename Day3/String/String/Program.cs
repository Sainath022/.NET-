//Write a program in C# Sharp to input a string and print it.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter your String:");
            s = Console.ReadLine();
            Console.WriteLine($"The String you given is '{s}'");
        }
    }
}
