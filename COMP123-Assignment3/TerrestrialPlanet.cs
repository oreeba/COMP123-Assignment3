using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    class TerrestrialPlanet: Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES******************************************************************
        private bool _oxygen;

        //CONSTRUCTORS********************************************************************************

        //This constructor Method takes all parameters of the Planet base class as well as oxygen as a local variable
        //and set the related instance variable

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
           : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //PUBLIC METHODS***************************************************************************
        //This method returns true if the Habitable property has oxygen

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

        //This method returns true if the MoonCount property is creater than zero

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

    }
}
