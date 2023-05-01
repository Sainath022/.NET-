using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq5
{
     public class Song
       {
        private string _name;

        private string _artist;

        private string _songType;

        private DateTime _dateDownloaded;

        private double _rating;

        private int _numberOfDownloads;

        public string Name
        {
            get {  return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songType; }   
            set { _songType = value; }
        }

        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads;  }
            set { _numberOfDownloads = value; }
        }

        public Song()
        {

        }

        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            DateDownloaded = dateDownloaded;
            Rating = rating;
            NumberOfDownloads = numberOfDownloads;
            
        }

         public static SortedDictionary<string,int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string,int> sd=new SortedDictionary<string,int>();
            foreach(var s in list) 
            {
                if(sd.ContainsKey(s.SongType))
                {
                    sd[s.SongType]++;
                }
                else
                {
                    sd.Add(s.SongType,1);
                }
                
            }
            return sd;

        }

    }
}
