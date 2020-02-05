using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public abstract class Songs : IComparable
    {
        private string artistname;

        public string SongName { get; set; }
        public string ArtistsName { get; set; }
        public DateTime ReleaseDate { get; set; }


        public Songs(string songname,string artistname,DateTime date)
        {
            SongName = songname;
            ArtistsName = artistname;
            ReleaseDate = date;
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
