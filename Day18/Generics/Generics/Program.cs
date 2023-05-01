using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharastra ", "Mumbai");
            s.Add("Karnataka ", "Bangalore");
            s.Add("Telangana", "Hyderabad");
            s.Add("Tamilnadu ", "chennai");
            s.Add("Bihar ", "Patna");
            s.Add("Rajastan ", "Jaipur");
            s.Add("Orissa ", "Bhubaneshwar");
            Console.WriteLine("Elements in the SotredList: ");
            foreach(var item  in s.Keys)
            {
                Console.WriteLine(item);
            }
            foreach(var item in s.Values)
            {
                Console.WriteLine(item);
            }
            IDictionaryEnumerator enumerator = s.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }

    }
}
