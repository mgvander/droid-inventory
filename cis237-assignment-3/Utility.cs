using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Utility : Droid
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
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
        protected Utility(
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
