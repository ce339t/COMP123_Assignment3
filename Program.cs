using System;

namespace COMP123_Assignment3
{
    /* Created By: Christina May Pakingan
      Student No. 301121940
      Date Created: 2020-07-12
      COMP 123 - Assignment 3 */

    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Ice","Jupiter", 20.20, 15.30);
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet(true, "Mars", 17.70, 16.20);
            Console.WriteLine("\n\n" + terrestrialPlanet.ToString());

            waitForAnyKey();
        }

        static void waitForAnyKey()
        {
            Console.ReadLine();
        }
    }
}
