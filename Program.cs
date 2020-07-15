using System;
using System.Net.NetworkInformation;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
      Student No. 301121940
      Date Created: 2020-07-12
      Date Modified: 2020-07-14
      COMP 123 - Assignment 3 */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***GIANT PLANET***");
            //Create an object for giant planet
            GiantPlanet giantPlanet = new GiantPlanet("Ice","Jupiter", 20.20, 15.30);
            Console.WriteLine(giantPlanet.ToString());

            Console.WriteLine("\n\n***TERRESTRIAL PLANET***");
            //Create an object for terrestrial planet
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet(true, "Mars", 17.70, 16.20);
            Console.WriteLine(terrestrialPlanet.ToString());


            waitForAnyKey();
        }

        static void waitForAnyKey()
        {
            Console.ReadLine();
        }
    }
}
