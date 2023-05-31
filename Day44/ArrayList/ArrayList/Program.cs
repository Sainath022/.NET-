using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            ArrayList[] lines = new ArrayList[n];

            for (int i = 0; i < n; i++)

            {

                string[] lineData = Console.ReadLine().Split(' ');

                int d = Convert.ToInt32(lineData[0]);

                lines[i] = new ArrayList(d);



                for (int j = 1; j <= d; j++)

                {

                    int num = Convert.ToInt32(lineData[j]);

                    lines[i].Add(num);

                }

            }



            int q = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < q; i++)

            {

                string[] queryData = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(queryData[0]);

                int y = Convert.ToInt32(queryData[1]);



                if (x > n || y >= lines[x - 1].Count)

                {

                    Console.WriteLine("ERROR!");

                }

                else

                {

                    int number = (int)lines[x - 1][y];

                    Console.WriteLine(number);

                }

            }
        }
    }
}
