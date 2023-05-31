using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthdaycake
{
    class Program

    {
        static int birthdayCakeCandles(int[] candles)

        {

            int maxHeight = 0;

            int count = 0;



            foreach (int height in candles)

            {

                if (height > maxHeight)

                {

                    maxHeight = height;

                    count = 1;

                }

                else if (height == maxHeight)

                {

                    count++;

                }

            }



            return count;

        }
        static void Main(string[] args)

        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] candles = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);



            int result = birthdayCakeCandles(candles);

            Console.WriteLine(result);

        }

    }
}
