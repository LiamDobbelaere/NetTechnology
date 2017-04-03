using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHobbies
{
    public class BandDA
    {
        private static BandDA instance;

        public static BandDA Instance {
            get
            {
                if (instance == null) instance = new BandDA();

                return instance;
            }
        }

        private BandDA()
        {
            this.Bands = new List<Band>();

            //Adding some default bands
            Band theBeatles = new Band("The Beatles", 1960);
            theBeatles.Members.Add(new Bandmember("John Lennon", 41, Gender.MALE, false));
            theBeatles.Members.Add(new Bandmember("Paul McCartney", 78, Gender.MALE, true));
            theBeatles.Members.Add(new Bandmember("George Harrison", 59, Gender.MALE, false));
            theBeatles.Members.Add(new Bandmember("Richard Starkey", 77, Gender.MALE, true));
            this.Bands.Add(theBeatles);
            
            Band metallica = new Band("Metallica", 1981);
            metallica.Members.Add(new Bandmember("James Alan Hetfield", 54, Gender.MALE, false));
            metallica.Members.Add(new Bandmember("Lars Ulrich", 54, Gender.MALE, false));
            metallica.Members.Add(new Bandmember("Kirk Hammett", 55, Gender.MALE, false));
            metallica.Members.Add(new Bandmember("Robert Trujillo", 53, Gender.MALE, false));
            this.Bands.Add(metallica);
        }

        public List<Band> Bands { get; set; }   
    }
}
