using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title, string origin) : base(title, origin)
        {
            //Title = title;
        }

        public override Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", true, Title, Origin);
            return rainStorm;
        }

        public Storm CastLightningStorm()
        {
            Storm lightningStorm = new Storm("lightning", true, Title, Origin);
            return lightningStorm;
        }
    }
}
