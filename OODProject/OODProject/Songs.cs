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

    public class Songs : IComparable
    {
        public string SongName { get; set; }
        public string ArtistsName { get; set; }
        public DateTime ReleaseDate { get; set; }


        public Songs(string songname,string artistname,DateTime date)
        {
            SongName = songname;
            ArtistsName = artistname;
            ReleaseDate = date;
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
