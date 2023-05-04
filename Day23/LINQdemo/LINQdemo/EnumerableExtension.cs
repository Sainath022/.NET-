using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    public static class EnumerableExtension
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.9, 2, 8, 4, 5.1, 6, 7};
            var query = numbers.Median();

            Console.WriteLine($" Median = {query}");

        }
        public static double Median(this IEnumerable<double> source)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute median for a null or empty set.");
            }

            var sortedList =
                source.OrderBy(number => number).ToList();

            int itemIndex = sortedList.Count / 2;

            if (sortedList.Count % 2 == 0)
            {
                
                return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
            }
            else
            {
                
                return sortedList[itemIndex];
            }
        }
       
    }
}

