using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         * Author: Oreeba Badar
         * Student # : 300865033
         * Date Modified: July 7th, 2016
         * Description: Main method for driver class Program  
         * Versions 0.0.3 -                 
         */

namespace COMP123_Assignment3
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("        GIANT PLANET: ");
            GiantPlanet giantPlanet = new GiantPlanet("        Gigantous", 1504199710, 0179914051, "Ice");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(giantPlanet.ToString());

            Console.WriteLine("*************************************");
            Console.WriteLine("        \n        TERRESTRIAL PLANET: ");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("        Infinitesimal", 101998, 899101, true);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("*************************************");
            waitForAnyKey();
        }

        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
        }
    }
    }

