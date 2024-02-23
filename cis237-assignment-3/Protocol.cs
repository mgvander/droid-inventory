using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class Protocol : Droid
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Type of droid model
        private const string MODELTYPE = "Protocol";

        // Price increase for a single language known
        private const decimal COST_PER_LANGUAGE_DECIMAL = 0.1m;

        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Number of languages (beyond binary) the droid is programmed with
        private int _numberOfLanguagesInteger;

        /*****************************************************************
         * Constructors
         * **************************************************************/
        public Protocol(
            string passDesignationString,
            string passMaterialString,
            string passColorString,
            int passNumOfLanguagesInteger) : base(
                passDesignationString,
                passMaterialString,
                passColorString)
        {
            // Set the number of languages the droid knows
            this._numberOfLanguagesInteger = passNumOfLanguagesInteger;

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
            //
            base.CalculateTotalCost();

            //
            base.TotalCost += this.CalculateSoftwareCost(_numberOfLanguagesInteger, COST_PER_LANGUAGE_DECIMAL);

        }

        public override string ToString()
        {
            //
            decimal totalLanguagesCostDecimal = this.CalculateSoftwareCost(_numberOfLanguagesInteger, COST_PER_LANGUAGE_DECIMAL);

            //
            return $"{base.ToString()}" +
               "Number of Languages:".PadRight(25) + $"{this._numberOfLanguagesInteger}".PadRight(14) + $"+ {totalLanguagesCostDecimal} Galactic Credits" + Environment.NewLine;

        }
        
    }

}
