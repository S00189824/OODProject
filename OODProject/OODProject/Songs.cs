using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject
{
    class Songs : IComparable
    {
        public string SongName { get; set; }
        public string AlbumName { get; set; }
        public string ArtistsName { get; set; }
        public DateTime ReleaseDate { get; set; }


        public Songs(string songname,string albumname,string artistname,DateTime date)
        {
            SongName = songname;
            AlbumName = albumname;
            ArtistsName = artistname;
            ReleaseDate = date;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
