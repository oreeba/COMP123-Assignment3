using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         * Author: Oreeba Badar
         * Student # : 300865033
         * Date Modified: July 8th, 2016
         * Description: Giant Planet Class                 
         */

namespace COMP123_Assignment3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //PRIVATE INSTANCE VARIABLES********************************************************************

        private string _type;

        //PUBLIC PROPERTIES*****************************************************************************

        public string Type
        {
            get
            {
                return this._type;
            }
        }
        //CONSTRUCTORS**********************************************************************************
        //This constructor Method takes all parameters of the Planet base class as well as type as a local variable 
        //and set the related instance variable

        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {

            //Assign local variable to instance variable
            this._type = type;
        }

        //PUBLIC METHODS********************************************************************************
        public bool HasMoons()
        {
            //This method returns true if the MoonCount property is creater than zero
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
            //This method returns true if the HasRings property is creater than zero
            if (RingCount < 0)
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
