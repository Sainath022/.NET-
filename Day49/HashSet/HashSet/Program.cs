using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program

    {

        static void Main()

        {

            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniquePairs = new HashSet<string>();

            for (int i = 0; i < n; i++)

            {

                string[] pair = Console.ReadLine().Split();

                string first = pair[0];

                string second = pair[1];

                string pairKey = $"{first} {second}";

                uniquePairs.Add(pairKey);

            }

            Console.WriteLine(uniquePairs.Count);

        }

    }
}
