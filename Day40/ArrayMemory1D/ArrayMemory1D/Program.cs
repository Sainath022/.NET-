using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMemory1D
{
    public class Program

    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Enter the number of Array elements:");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter the Elements:");

            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)

            {

                a[i] = Convert.ToInt32(input[i]);

            }

            Console.WriteLine("Elements in the array:");

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine(a[i]);

            }

        }

    }
}
