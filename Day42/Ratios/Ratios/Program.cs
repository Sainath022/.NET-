using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratios
{
    class Program

    {
        static void plusMinus(int[] arr)

        {

            int positiveCount = 0;

            int negativeCount = 0;

            int zeroCount = 0;

            foreach (int num in arr)

            {

                if (num > 0)

                    positiveCount++;

                else if (num < 0)

                    negativeCount++;

                else

                    zeroCount++;

            }
            int total = arr.Length;



            double positiveRatio = (double)positiveCount / total;

            double negativeRatio = (double)negativeCount / total;

            double zeroRatio = (double)zeroCount / total;



            Console.WriteLine(positiveRatio.ToString("F6"));

            Console.WriteLine(negativeRatio.ToString("F6"));

            Console.WriteLine(zeroRatio.ToString("F6"));

        }
        static void Main(string[] args)

        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);



            plusMinus(arr);

        }

    }
}
