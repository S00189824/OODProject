using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OODProject;

namespace MusicManager
{
    class Program
    {
        static void Main(string[] args)
        {
            SongDataInfo db = new SongDataInfo();

            using (db)
            {
                ArtistInfo artist1 = new ArtistInfo() { ID = 1, Artistname = "Nier",ArtistImage = "Pic2" };
                SongInfo song1 = new SongInfo() { SongID = 1, SongName = "Dark Colossus - Kaiju",ID = 1, ArtistsInfo = artist1};
                SongInfo song2 = new SongInfo() { SongID = 2, SongName = "Emil - Despair", ID = 1, ArtistsInfo = artist1};
                SongInfo song3 = new SongInfo() { SongID = 3, SongName = "Significance - Nothing - J'Nique Nicole", ID = 1, ArtistsInfo = artist1};
                SongInfo song4 = new SongInfo() { SongID = 4, SongName = "The Sound of the End", ID = 1, ArtistsInfo = artist1};
                SongInfo song5 = new SongInfo() { SongID = 5, SongName = "War & War", ID = 1, ArtistsInfo = artist1};


                ArtistInfo artist2 = new ArtistInfo() { ID = 2, Artistname = "Witcher", ArtistImage = "Pic1" };
                SongInfo song6 = new SongInfo() { SongID = 6, SongName = "02. Geralt Of Rivia", ID = 2, ArtistsInfo = artist2 };
                SongInfo song7 = new SongInfo() { SongID = 7, SongName = "10. Silver For Monsters...", ID = 2, ArtistsInfo = artist2 };
                SongInfo song8 = new SongInfo() { SongID = 8, SongName = "12. The Nightingale", ID = 2, ArtistsInfo = artist2 };
                SongInfo song9 = new SongInfo() { SongID = 9, SongName = "GWENT The Witcher Card Game OST - Monstrous Might", ID = 2, ArtistsInfo = artist2 };
                SongInfo song10 = new SongInfo() { SongID = 10, SongName = "The Bloody Mistress Thronebreaker The Witcher Tales OST", ID = 2, ArtistsInfo = artist2 };


                db.Artists.Add(artist1);
                db.Artists.Add(artist2);

                db.Songs.Add(song1);
                db.Songs.Add(song2);
                db.Songs.Add(song3);
                db.Songs.Add(song4);
                db.Songs.Add(song5);
                db.Songs.Add(song6);
                db.Songs.Add(song7);
                db.Songs.Add(song8);
                db.Songs.Add(song9);
                db.Songs.Add(song10);

                Console.WriteLine("Added Songs to Database");

                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
