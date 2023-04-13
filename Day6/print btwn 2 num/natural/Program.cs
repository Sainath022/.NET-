using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace natural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Starting num");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending num");
            b = int.Parse(Console.ReadLine());
            for(a=a; a <= b; a++)
            { Console.WriteLine(a); }
        }
    }
}
