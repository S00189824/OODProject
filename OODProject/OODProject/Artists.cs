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
        public int ID { get; set; } 
        public string Artistname { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }

        public int SongID { get; set; }
        public virtual Songs Songs { get; set; }

        
    }

    public class Songs
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string SongImage { get; set; }
        public string SongFile { get; set; }

        public virtual List <Artists> Artists { get; set; }
    }
}
