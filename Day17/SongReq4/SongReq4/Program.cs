using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int type;
            List<Song> list = new List<Song>();

            {

                new Song("The Way", "Fastball", "Emotional", DateTime.Parse("12-01-2002"), 4.6, 12000);

                new Song("Man World", "Gray jules", "Emotional", DateTime.Parse("01-03-2001"), 4.7, 13000);

                new Song("Let It Be", "The Beatless", "Motivational", DateTime.Parse("02-03-2004"), 4.2, 12000);

            }

            //Console.WriteLine("name \t artist\t songType\t dateDownloaded\t rating\t numberOfDownloads\t ");

            foreach (Song s in list)

            {

                Console.WriteLine(s);

            }

            list.Sort();
            Console.WriteLine("Enter the No.of songs:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Type to Sort");
            Console.WriteLine("1.Sort by Name");
            Console.WriteLine("2.Sort by Artist");
            Console.WriteLine("3.Sort by SongType");
            Console.ReadLine();

            foreach (Song s in list)

            {

                Console.WriteLine(s);

            }

        }
    }
}

