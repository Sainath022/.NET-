using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            int n, sum;
           
            Console.WriteLine("Enter length of N:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sum:");
            sum = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter your array elements:" + arr);
                arr[i] = int.Parse(Console.ReadLine());

            }
            subarray(n,sum,arr);
           
        }

        public static void subarray(int n,int sum, int[] arr)
        {
           
            
            for ( int i = 0; i < n; i++)
            {

                int currentSum = arr[i];

                if (currentSum == sum)
                {

                    Console.WriteLine("Sum found at indexe " + i );

                    return;

                }
                else

                {
                    for (int j = i + 1; j < n; j++)
                    {

                        currentSum += arr[j];

                        if (currentSum == sum)
                        {

                            Console.WriteLine("Sum found between indexes " + i + " and " + j);

                            return;

                        }

                    }

                }

            }

            Console.WriteLine("No subarray found");


        }

    }

}




