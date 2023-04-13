//Write a program in C# Sharp to find the length of a string without using library function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int length=0;
            Console.WriteLine("Enter the string : ");
            s = Console.ReadLine();

            foreach(char chr in s)
            {
                length += 1;
            }

            Console.WriteLine("Length of the string is : {0}", length);
        }
    }
}
