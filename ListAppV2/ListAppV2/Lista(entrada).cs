using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAppV2
{
    public class Lista
    {
        public static List<Album> ListAlbum()

        {
            List<Album> Albuns = new List<Album>();

            Albuns.Add(new Album("Last Wink", "Felt"));
            Albuns.Add(new Album("Remaster Collection", "Felt", 3));

            Albuns.Add(new Album("Rebirth History", "Felt"));
            Albuns.Add(new Album("Navigation Il Mare", "Forest 306"));

            Albuns.Add(new Album("Abyss Nova", "Felt"));
            Albuns.Add(new Album("Invencible", "Two Steps From Hell"));

            Albuns.Add(new Album("Rebirth History 2", "Felt"));
            Albuns.Add(new Album("Eternal Summer", "Akatsuki Records"));
            {
                return Albuns;
            }
        }


    }
}
