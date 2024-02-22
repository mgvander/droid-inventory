using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class Janitor : Utility
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Type of droid model
        private const string MODELTYPE = "Janitor";

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
            // Set if the droid is equipped with a broom
            this._broomBoolean = passBroomBoolean;

            // Set if the droid is equipped with a vacuum
            this._vacuumBoolean = passVacuumBoolean;

        }

        /*****************************************************************
         * Properties
         * **************************************************************/
        //
        public override string Model
        {
            get { return MODELTYPE; }
        }

        /*****************************************************************
         * Methods
         * **************************************************************/
        public override void CalculateTotalCost()
        {

        }

        public override string ToString()
        {
            //
            return $"{base.ToString()}" +
                "Broom:".PadRight(25) + $"{this._broomBoolean}" + Environment.NewLine +
                "Vacuum:".PadRight(25) + $"{this._vacuumBoolean}" + Environment.NewLine;

        }

    }

}
