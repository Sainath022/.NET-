using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalpairs
{
    class Program

    {
        static long countPairs(int[] arr)

        {

            int n = arr.Length;

            long pairCount = 0;

            int[] frequency = new int[101];

            for (int i = 0; i < n; i++)

            {

                frequency[arr[i]]++;

            }

            for (int i = 0; i < n; i++)

            {

                pairCount += frequency[arr[i]] - 1;

                frequency[arr[i]] = 0;

            }
            return pairCount;

        }

        static void Main(string[] args)

        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);



            long result = countPairs(arr);

            Console.WriteLine(result);

        }

    }
}
