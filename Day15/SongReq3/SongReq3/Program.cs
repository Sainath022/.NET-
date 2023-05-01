using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongsRepo.GetallSongs();

            foreach (Song s in ls)

            {

                Console.WriteLine(s.ToString());

            }
        }
    }
}
