using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
      Student No. 301121940
      Date Created: 2020-07-12
      Date Modified: 2020-07-14
      COMP 123 - Assignment 3 */

    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {

        //Private Field
        private bool _oxygen;


        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        public bool HasMoons()
        {

            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
