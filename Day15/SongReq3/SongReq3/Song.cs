using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq3
{
    class Song 
    {
        private string _name;
        private string _artist;
        private string _songtype;
        private double _rating;
        private int _noOfDownloads;
        private DateTime _dateDownloaded;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songtype; }
            set { _songtype = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NoOfDownloads
        {
            get { return _noOfDownloads; }
            set { _noOfDownloads = value; }
        }
        public DateTime DateDownloaded
        { 
            get { return _dateDownloaded; } 
            set { _dateDownloaded = value; } 
        }
        public Song() 
        {
        
        }
        public Song(string name, string artist, string songtype, double rating, int noOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songtype = songtype;
            _rating = rating;
            _noOfDownloads = noOfDownloads;
            _dateDownloaded = dateDownloaded;
            
        }
        public override string ToString()

        {

            return string.Format("Name of  the Song:{0}\n Artist: {1}\n Songtype:{2}\n Rating:{3}\n NoOfDownloads:{4}\n DateDownloaded:{5}\n", _name, _artist,_songtype,_rating,_noOfDownloads,_dateDownloaded);

        }
    }
}
