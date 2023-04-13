using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int r=0,amount=0;
            Console.WriteLine("enter the amount: ");
            amount=int.Parse(Console.ReadLine());
            countCurrency(amount);
            
        }
        public static void countCurrency(int amount)
        {
            int[] typeofnotes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noofnotes = new int[9];


            for (int i = 0; i < 9; i++)
            {
                if (amount >= typeofnotes[i])
                {
                    noofnotes[i] = amount / typeofnotes[i];
                    amount = amount % typeofnotes[i];
                }
            }

            Console.WriteLine("Currency Count:");
            for (int i = 0; i < 9; i++)
            {
                if (noofnotes[i] != 0)
                {
                    Console.WriteLine(typeofnotes[i] + " : " + noofnotes[i]);
                }
            }
        }

    }
}
