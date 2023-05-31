using System;
using System.Linq;
using System.Globalization;
using System.Collections;

namespace Bigdecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());



            string[] s = new string[n];



            for (int i = 0; i < n; i++)

            {

                s[i] = Console.ReadLine();

            }



            Array.Sort(s,new RealNumberStringComparer());



            foreach (string number in s)

            {

                Console.WriteLine(number);

            }

        }
    
    }
}
