using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
      Student No. 301121940
      Date Created: 2020-07-12
      COMP 123 - Assignment 3 */

    abstract class Planet
    {
        private double _diameter, _mass, _orbitalPeriod, _rotationPeriod;
        private int _moonCount, _ringCount;
        private string _name;

        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }


        public Planet(string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }

        

        public override string ToString()
        {
            return $"Name: {Name}\nDiameter: {Diameter}\nMass: {Mass}";
        }

       
       

    }
}
