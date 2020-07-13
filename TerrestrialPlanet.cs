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
      COMP 123 - Assignment 3 */

    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;


        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        public bool HasMoons()
        {
            
                bool hasmoon = MoonCount > 0;

                return hasmoon;

            }

        public bool Habitable()
        {
            bool habitable = _oxygen == true;

            return habitable;
        }

        
    }
}
