using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq3
{
    internal class SongsRepo
    {
        static List<Song> Songs = new List<Song>

        {
            new Song("AfterHours", "Weeknd", "pop", 5.0,90000000,DateTime.Parse("01-01-2020")),
            new Song("The Hills","Weeknd","pop",4.9,60000000,DateTime.Parse("02-01-2020")),
            new Song("Starboy","Weeknd","pop",4.8,80000000,DateTime.Parse("03-01-2020"))
        };
        public static List<Song> GetallSongs()
        {
            return Songs;
        }
    }
}
