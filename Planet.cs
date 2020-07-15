using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
      Student No. 301121940
      Date Created: 2020-07-12
      Date Modified: 2020-07-14
      COMP 123 - Assignment 3 */

    abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter, _mass, _orbitalPeriod, _rotationPeriod;
        private int _moonCount, _ringCount;
        private string _name;

        //PUBLIC PROPERTIES
        public double Diameter
        {
            get { return _diameter; }
        }

        public double Mass
        {
            get { return _mass; }
        }

        public int MoonCount
        {
            get { return _moonCount; }
        }

        public string Name
        {
            get { return _name; }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        //PUBLIC CONSTRUCTOR
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        

        public override string ToString()
        {
            return $"Name: {Name}\nDiameter: {Diameter}\nMass: {Mass}";
        }

       
       

    }
}
