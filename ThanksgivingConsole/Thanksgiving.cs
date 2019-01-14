using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanksgivingConsole
{
    public class Thanksgiving
    {
        public string MainCourse { get; set; }
        public bool MashedPotatoes { get; set; }
        public int NumberOfSideDishes { get; set; }
        public bool PilgrimHats { get; set; }

        public Thanksgiving(string mainCourse, bool mashedPotatoes, int numberOfSideDishes, bool pilgrimHats)
        {
            MainCourse = mainCourse;
            MashedPotatoes = mashedPotatoes;
            NumberOfSideDishes = numberOfSideDishes;
            PilgrimHats = pilgrimHats;
        }

        public Thanksgiving()
        {

        }
    }
}
