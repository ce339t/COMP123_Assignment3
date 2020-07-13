using System;
using System.Linq.Expressions;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
       Student No. 301121940
       Date Created: 2020-07-12
       COMP 123 - Assignment 3 */

    class GiantPlanet :Planet, IHasMoons, IHasRings
    {

    //Variable declaration
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
                Console.WriteLine("Incorrect Type entered. Gas and Ice are only the 2 options.");
            }


        }
         public bool HasMoons()
        {
            bool hasmoons = (MoonCount > 0);
            return hasmoons;
        }


         public bool HasRings()
         {
             bool hasrings = (RingCount > 0);

             return hasrings;


         }

    }
}

 
