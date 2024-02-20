using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Astromech : Utility
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Price increase if the droid can operate a navi computer
        private const decimal COST_OF_NAVIGATION_DECIMAL = 0m;
        // Price increase for knowing how to operate a single ship type
        private const decimal COST_PER_SHIP_DECIMAL = 0m;

        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Does the droid have the programming to interface with a navi computer
        private bool _navigationBoolean;
        // Number of ship types the droid can operate
        private int _numberOfShipsInteger;

        /*****************************************************************
         * Constructors
         * **************************************************************/
        private Astromech(
            string passDesignationString,
            string passMaterialString,
            string passColorString,
            bool passToolsBoolean,
            bool passDataProbeBoolean,
            bool passScannerBoolean,
            bool passNavigationBoolean,
            int passShipsInteger) : base(
                passDesignationString,
                passMaterialString,
                passColorString,
                passToolsBoolean,
                passDataProbeBoolean,
                passScannerBoolean)
        {

        }

        /*****************************************************************
         * Methods
         * **************************************************************/
        private void CalculateTotalCost()
        {

        }

        public override string ToString()
        {
            return "";

        }

    }

}
