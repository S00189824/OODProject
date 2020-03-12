using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject
{
    public class Artists
    {
        public string Artistname { get; set; }
        public List<Albums> albums { get; set; }
        public DirectoryInfo directoryInfo { get; set; }

        public Artists( string artistname)
        {

        }

        public Artists(string artistname, DirectoryInfo directoryInfo)
        {
            this.directoryInfo = directoryInfo;
            Artistname = artistname;
            this.albums = new List<Albums>();
        }
    }
}
