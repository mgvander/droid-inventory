using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Protocol : Droid
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Price increase for a single language known
        private const decimal COST_PER_LANGUAGE_DECIMAL = 0m;

        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Number of languages (beyond binary) the droid is programmed with
        private int _numberOfLanguagesInteger;

        ///*****************************************************************
        // * Properties
        // * **************************************************************/
        //private int NumberOfLanguages { get; set; }

        /*****************************************************************
         * Constructors
         * **************************************************************/
        private Protocol(
            string passDesignationString,
            string passMaterialString,
            string passColorString,
            int passNumOfLanguagesInteger) : base(
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
