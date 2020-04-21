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
            SongData db = new SongData();

            using (db)
            {
                /*Artists artist1 = new Artists() { ID = 1, Artistname = "NierAutomata", Genre = "Composed" };
                Songs song1 = new Songs() { SongID = 1, SongName = "War & War", SongFile = "Mp3", SongImage = "Pic2",ID = 1, Artists = artist1};*/
                //Songs song3 = new Songs() { SongID = 3, SongName = "Dark Colossus - Kaiju",SongFile = "Mp3",SongImage = "Pic2",ID = 1,Artists =  }

                /*Artists artist2 = new Artists() { ID = 2, Artistname = "Witcher OST", Genre = "Composed"};
                Songs song2 = new Songs() { SongID = 2, SongName = "GWENT The Witcher Card Game OST - Monstrous Might", SongFile = "Mp3", SongImage = "Pic1",ID = 2,Artists = artist2};*/

                /*db.Artists.Add(artist1);
                db.Artists.Add(artist2);

                Console.WriteLine("Added Artists to database");

                db.Songs.Add(song1);
                db.Songs.Add(song2);*/

                



                Console.WriteLine("Added Songs to Database");

                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
