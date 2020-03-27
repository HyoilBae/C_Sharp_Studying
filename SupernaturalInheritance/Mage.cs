using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Mage : Pupil
    {
        //public string Title { get; private set; }

        public Mage(string title, string origin) : base(title, origin)
        {
            //Title = title;
        }

        //public Storm CastWindStorm()
        //{
        //    Storm pupilStorm = new Storm("wind", false, Title);
        //    return pupilStorm;
        //}

        public virtual Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", false, Title, Origin);
            return rainStorm;
        }
    }
}
