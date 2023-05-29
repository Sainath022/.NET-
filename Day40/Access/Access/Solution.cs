using System;

namespace Access
{
    class Solution
    {
        private class Inner
        {
            private static bool PowerOf2(int num)
            {
                return (num > 0) && ((num & (num - 1)) == 0);
            }

            private static void Main(string[] args)

            {

                int num = Convert.ToInt32(Console.ReadLine());

                bool isPowerOf2 = Inner.PowerOf2(num);

                Console.WriteLine("Is Power of 2: " + isPowerOf2);

            }
        }
    }
}

