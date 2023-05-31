using System;
using System.Numerics;
using System.Runtime.Remoting.Services;

namespace Biginteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            BigInteger a = BigInteger.Parse(Console.ReadLine());

            BigInteger b = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = a + b;

            BigInteger product = a * b;

            Console.WriteLine(sum);

            Console.WriteLine(product);
        }
    }
}
