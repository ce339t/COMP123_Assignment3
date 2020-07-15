using System;
using System.Linq.Expressions;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
       Student No. 301121940
       Date Created: 2020-07-12
       Date Modified: 2020-07-14
       COMP 123 - Assignment 3 */

    class GiantPlanet :Planet, IHasMoons, IHasRings
    {

    //Variable declaration - Private Field
        private string _type;

    //Constructor
        public GiantPlanet(string type, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            if ((type == "Gas") || (type == "Ice"))
            {
                this._type = type;
                Console.WriteLine("Type: "+this._type);
            }
            else
            {
                Console.WriteLine("Incorrect Type entered. Gas and Ice are the only options.");
            }


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


         public bool HasRings()
         {
             if (RingCount > 0)
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

 
