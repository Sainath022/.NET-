using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    public class HourglassSum

    {

        public static void Main(string[] args)

        {

            // Read the 6x6 2D array from input

            int[,] arr = new int[6, 6];

            Console.WriteLine("Enter the 6x6 array elements:");

            for (int i = 0; i < 6; i++)

            {

                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < 6; j++)

                {

                    arr[i, j] = Convert.ToInt32(input[j]);

                }

            }

            // Calculate the largest hourglass sum

            int maxSum = int.MinValue;

            for (int i = 0; i <= 3; i++)

            {

                for (int j = 0; j <= 3; j++)

                {

                    int sum = CalculateHourglassSum(arr, i, j);

                    maxSum = Math.Max(maxSum, sum);

                }

            }

            // Print the largest sum

            Console.WriteLine("Largest hourglass sum: " + maxSum);

        }

        private static int CalculateHourglassSum(int[,] arr, int row, int col)

        {

            int sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2]

                         + arr[row + 1, col + 1]

               + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

            return sum;

        }
    }
}
