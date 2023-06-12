using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        public interface AdvancedArithmetic

        {

            int divisorSum(int n);

        }
        class MyCalculator : AdvancedArithmetic

        {

            public int divisorSum(int n)

            {

                int sum = 0;

                for (int i = 1; i <= n; i++)

                {

                    if (n % i == 0)

                    {

                        sum += i;

                    }

                }

                return sum;

            }

        }
        class Solution

        {

            static void Main(string[] args)

            {

                int n = int.Parse(Console.ReadLine());

                AdvancedArithmetic myCalculator = new MyCalculator();

                int sum = myCalculator.divisorSum(n);

                Console.WriteLine("I implemented: AdvancedArithmetic");

                Console.WriteLine(sum);

            }

        }
    }
}
