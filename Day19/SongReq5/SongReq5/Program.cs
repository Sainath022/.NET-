using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Song> list = new List<Song>();

            Console.WriteLine("Enter the number of songs");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine("Enter the Name of Song,Artist,SongType,Date of Download,Rating,Number of Downloads"
                    );

                string input = Console.ReadLine();

                string[] arr = input.Split(',');

                string name = arr[0];

                string artist = arr[1];

                string songType = arr[2];

                DateTime dateDownloaded = Convert.ToDateTime(arr[3]);

                double rating = double.Parse(arr[4]);

                int numberOfDownloads = int.Parse(arr[5]);

                

                Song s = new Song(name, artist, songType, dateDownloaded, rating, numberOfDownloads );

                list.Add(s);

            }

            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();

            sd = Song.CalculateTypeCount(list);

            Console.WriteLine("SongType\t count");
            foreach (var s in sd) 
            {
            Console.WriteLine(s.Key+ "\t\t" + s.Value);
            }

        }

    }

}
        
