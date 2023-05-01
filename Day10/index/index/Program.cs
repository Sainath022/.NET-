using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
     
     class Program
    {
        int[] arr = new int[] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }


        static void Main(string[] args)
        {
            Program a;
            a = new Program();
            a[3] = 30;
            Console.WriteLine(a[3]);
        }
    }
}
