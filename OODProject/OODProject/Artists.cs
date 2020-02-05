using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject
{
    class Artists : Songs
    {
        public Artists(string songname, string artistname, DateTime date) : base(songname, artistname, date)
        {

        }

        public Artists(string artistname) : base(artistname)
        {

        }

        public override string ToString()
        {
            return ArtistsName;
        }
    }
}
