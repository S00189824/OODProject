using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OODProject
{
    public enum GenreType
    {
        Metal,
        Rock,
        POP,
        Indie,
        Jazz,
        Rap,

    }

    public class Songs : IComparable
    {
        private string artistname;

        public string SongName { get; set; }
        public int TrackNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public FileInfo file { get; set; }

        public TimeSpan Time;

        public int ReleaseYear
        {
            get
            {
                return ReleaseDate.Year;
            }
        }

        


        public Songs(string songname,int track,DateTime date,TimeSpan time,FileInfo f)
        {
            SongName = songname;
            TrackNumber = track;
            ReleaseDate = date;
            Time = time;
            file = f;
        }

        public Songs(string artistname)
        {
            this.artistname = artistname;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return SongName;
        }
    }
}
