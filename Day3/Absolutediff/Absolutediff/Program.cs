using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Absolutediff
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n,dif;
            Console.WriteLine("Enter your number:");
            n = int.Parse(Console.ReadLine());
            dif = caldif(n);
            Console.WriteLine(dif);
        }
        static int caldif(int n) 
        {
            int x = 51;
            if (n > x)
            {
                return (n - x) * 3;
            }
            return (x-n);
        }

    }
}
