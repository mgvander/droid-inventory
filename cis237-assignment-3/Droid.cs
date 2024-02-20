using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    abstract class Droid : IDroid
    {
        /*****************************************************************
         * Variables / Backing Fields
         * **************************************************************/
        // Total cost of a droid
        private decimal _totalCostDecimal;
        // Serial designation of the driod
        private string _serialDesignationString;
        // Hull material of a droid
        private string _materialString;
        // Hull coloring
        private string _colorString;

        /*****************************************************************
         * Properties
         * **************************************************************/
        // Total cost of a droid
        public decimal TotalCost { get; set; }

        // Serial designation of the driod
        private string SerialDesignation { get; set; }

        // Hull material of a droid
        private string Material { get; set; }

        // Hull coloring
        private string Color { get; set; }

        /*****************************************************************
         * Constructors
         * **************************************************************/
        protected Droid(string passDesignationString, string passMaterialString, string passColorString)
        {
            // Set the droid's serial designation
            this._serialDesignationString = passDesignationString;
            // Set the droid's hull material
            this._materialString = passMaterialString;
            // Set the droid's hull color
            this._colorString = passColorString;

        }

        /*****************************************************************
         * Methods
         * **************************************************************/
        
        public void CalculateTotalCost()
        {

        }

        public override string ToString()
        {
            return "";

        }

    }

}
