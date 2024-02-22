using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class Utility : Droid
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Type of droid model
        private const string MODELTYPE = "Utility";

        // Price increase if the droid is equipped with a tool box
        private const decimal COST_OF_TOOL_BOX_DECIMAL = 0m;
        // Price increase if the droid is equipped with a data probe
        private const decimal COST_OF_COMPUTER_CONNECTION_DECIMAL = 0m;
        // Price increase if the droid is equipped with a scanner
        private const decimal COST_OF_SCANNER_DECIMAL = 0m;

        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Does the droid have a tool box
        private bool _toolBoxBoolean;
        // Does the droid have a data probe
        private bool _computerConnectionBoolean;
        // Does the droid have a scanner
        private bool _scannerBoolean;

        /*****************************************************************
         * Constructors
         * **************************************************************/
        public Utility(
            string passDesignationString,
            string passMaterialString,
            string passColorString,
            bool passToolsBoolean,
            bool passComputerJackBoolean,
            bool passScannerBoolean) : base(
                passDesignationString,
                passMaterialString,
                passColorString)
        {
            // Set if the droid is equipped with a toolbox
            this._toolBoxBoolean = passToolsBoolean;

            // Set if the droid is equipped with a computer connection
            this._computerConnectionBoolean = passComputerJackBoolean;

            // Set if the droid is equipped with a scanner
            this._scannerBoolean = passScannerBoolean;

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
                "Tool Box:".PadRight(25) + $"{this._toolBoxBoolean}" + Environment.NewLine +
                "Data Probe:".PadRight(25) + $"{this._computerConnectionBoolean}" + Environment.NewLine +
                "Scanner Array:".PadRight(25) + $"{this._scannerBoolean}" + Environment.NewLine;

        }

    }

}
