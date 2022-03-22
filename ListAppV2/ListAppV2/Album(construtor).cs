using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAppV2
{


    public class Album
    {
        public string _name { get; set; }
        public string _composer { get; set; }
        public DateTime _Release_date { get; set; }
        public int _track_count { get; set; }
        public Album()
        {
        }

        public Album(string name, string composer)
        {
            _name = name;
            _composer = composer;
        }
        public Album(string name, string composer, int track_count)
        {
            _name = name;
            _composer = composer;
            _track_count = track_count;
        }

        //print dos albuns
        public static void Listacw()
        {

            List<Album> Albuns = Lista.ListAlbum();
            Console.WriteLine(" \n Short by album name \n");
            foreach (var x in Albuns.OrderBy(x => x._name))
            {
                Console.WriteLine($"Album: { x._name}    Composer: {x._composer}");
            }
            Console.WriteLine(" \n Short by album composer \n");
            foreach (var x in Albuns.OrderBy(x => x._composer))
            {
                Console.WriteLine($"Album: { x._name}    Composer: {x._composer}");
            }
            Console.WriteLine(" \n Short by album track number \n");
            foreach (var x in Albuns.OrderByDescending(x => x._track_count))
            {
                if (x._track_count > 0)
                {
                    Console.WriteLine($"Album: { x._name}    Composer: {x._composer}     N' of tracks: {x._track_count}");
                }

            }

        }





    }

}