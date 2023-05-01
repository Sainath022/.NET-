using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq4
{
    internal class Song : IComparable<Song>
    {
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime _dateDownloaded;
        private double _rating;
        private int _noOfDownloads;

        public string Name { get { return _name; } set { _name = value; } }
        public string Artist { get { return _artist; } set { _artist = value; } }

        public string SongType { get { return _songType; } set { _songType = value; } }

        public DateTime DateDownloaded
        { get 
            { 
                return _dateDownloaded;
            }
          set
            {
                _dateDownloaded = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
            }
        }

        public int NoOfDownloads
        {
            get { return _noOfDownloads; }
            set
            {
                _noOfDownloads = value;
            }
        }
        public Song()
        {

        }
        public Song(string name,string artist,string songType,DateTime datedownloaded,double rating,int noOfDownloads)
        {
            _name= name;
            _artist= artist;
            _songType= songType;
            _dateDownloaded= datedownloaded;
            _rating= rating;
            _noOfDownloads= noOfDownloads;
        }

        public override string ToString()
        {
            return string.Format($"Name of Song:{_name}\n Artist:{_artist}\n SongType:{_songType}\n DateDownloaded:{_dateDownloaded}\n Rating:{_rating}\n NoOfDownloads:{_noOfDownloads}\n ");
        }

        public int CompareTo(Song Other)
        {
            return Name.CompareTo( Other.Name );
            
            
        }


    }
}
