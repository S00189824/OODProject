using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject
{
    public class ArtistInfo
    {
        [Key]
        public int ID { get; set; }
        public string Artistname { get; set; }
        public string ArtistImage { get; set; }

        public virtual List<SongInfo> SongsInfo { get; set; }
    }

    public class SongInfo
    {
        [Key]
        public int SongID { get; set; }
        public string SongName { get; set; }
        

        public int ID { get; set; }
        public virtual ArtistInfo ArtistsInfo { get; set; }



    }


    public class SongDataInfo : DbContext
    {
        public SongDataInfo() : base("MusicPlayerData") { }

        public DbSet<ArtistInfo> Artists { get; set; }
        public DbSet<SongInfo> Songs { get; set; }
    }
}
