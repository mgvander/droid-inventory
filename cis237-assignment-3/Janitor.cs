using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Janitor : Utility
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Price increase if the droid is equipped with a broom
        private const decimal COST_OF_BROOM_DECIMAL = 0m;
        // Price increase if the droid is equipped with a vacuum
        private const decimal COST_OF_VACUUM_DECIMAL = 0m;

        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Does the droid have a broom
        private bool _broomBoolean;
        // Does the droid have a vacuum
        private bool _vacuumBoolean;

        /*****************************************************************
         * Constructors
         * **************************************************************/
        public Janitor(
            string passDesignationString,
            string passMaterialString,
            string passColorString,
            bool passToolsBoolean,
            bool passComputerJackBoolean,
            bool passScannerBoolean,
            bool passBroomBoolean,
            bool passVacuumBoolean) : base(
                passDesignationString,
                passMaterialString,
                passColorString,
                passToolsBoolean,
                passComputerJackBoolean,
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
