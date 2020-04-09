using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject
{
    public class Artists
    {
        [Key]
        public int ID { get; set; }
        public string Artistname { get; set; }
        public string Genre { get; set; }

        

        public virtual List<Songs> Songs { get; set; }
    }

    public class Songs
    {
        [Key]
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string SongImage { get; set; }
        public string SongFile { get; set; }


        public int ID { get; set; }
        public virtual Artists Artists { get; set; }

    }

    public class SongData : DbContext
    {
        public SongData() : base("MySongData") { }

        public DbSet<Artists> Artists { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
}
