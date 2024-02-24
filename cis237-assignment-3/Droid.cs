/// Author: Michael VanderMyde
/// Course: CIS-237
/// Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    public abstract class Droid : IDroid
    {
        /*****************************************************************
         * Constants
         * **************************************************************/
        // Number of predetermined materials the user can choose from
        private const int NUMBER_OF_MATERIALS = 9;

        // Array of predetermined materials the user can choose from
        private string[] _materials = new string[NUMBER_OF_MATERIALS] {
            "Chromium",
            "Cortosis",
            "Dolovite",
            "Duraplast",
            "Durasteel",
            "Iron",
            "Plasteel",
            "Platinum",
            "Silver" };

        // An array parallel to the materials array, containing the cost of the materials
        private decimal[] _materialPrices = new decimal[NUMBER_OF_MATERIALS] {
            11_000m,
            12_000m,
            9_000m,
            8_000m,
            10_000m,
            8_500m,
            9_500m,
            15_000m,
            13_000m };

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
         * Properties
         * **************************************************************/
        // Total cost of a droid
        public decimal TotalCost
        {
            get { return _totalCostDecimal; }
            set { _totalCostDecimal = value; }
        }

        // The type of droid
        public abstract string Model { get; }

        // The array of materials
        public string[] Materials
        {
            get { return this._materials; }
        }

        // The array of material prices
        public decimal[] MaterialPrices
        {
            get { return this._materialPrices; }
        }

        // The material the droid is made out of
        public string Material
        {
            get { return _materialString; }
        }
        
        /*****************************************************************
         * Methods
         * **************************************************************/
        /// <summary>
        /// Adds calculated material cost to the class property, TotalCost
        /// </summary>
        public virtual void CalculateTotalCost()
        {
            // Add the cost of the material to the TotalCost
            this.TotalCost += this.CalculateMaterialCost();

        }

        /// <summary>
        /// Create a formatted series of strings containing the values
        /// associated with the Droid class
        /// </summary>
        /// <returns> The formatted string of a droid's name, hull
        /// material, and hull color </returns>
        public override string ToString()
        {
            // Set the variable to the cost
            decimal totalMaterialCost = this.CalculateMaterialCost();

            // Return the formatted concatenated string a values associated with the Droid class
            return "Serial Designation:".PadRight(25) + $"{this._serialDesignationString}" + Environment.NewLine +
                "Hull Material:".PadRight(25) + $"{this._materialString}".PadRight(14) + $"+ {totalMaterialCost} Galactic Credits" + Environment.NewLine +
                "Hull Color:".PadRight(25) + $"{this._colorString}" + Environment.NewLine;

        }

        /// <summary>
        /// Search for a value in the materials array that matches the value of
        /// the droid's material and then return the cost of the that material.
        /// </summary>
        /// <returns> The price of the droid's material </returns>
        protected decimal CalculateMaterialCost()
        {
            // Check that the class Property holds a value
            if (this.Material != null)
            {
                // Iterate through the length of the materials array
                for (int indexInteger = 0; indexInteger < this.Materials.Length; ++indexInteger)
                {
                    //
                    if (string.Equals(this.Materials[indexInteger], this.Material))
                    {
                        //
                        int materialIndexInteger = indexInteger;

                        //
                        return this.MaterialPrices[materialIndexInteger];

                    }

                }

            }
            
            //
            return 0;

        }

        protected decimal CalculateEquipmentCost(bool passEquippedBoolean, decimal passPriceDecimal)
        {
            
            //
            if (passEquippedBoolean)
            {
                //
                return passPriceDecimal;

            }
           
            //
            return 0;           

        }

        protected decimal CalculateSoftwareCost(int passSoftwaresInteger, decimal passPriceDecimal)
        {
            //
            return passSoftwaresInteger * passPriceDecimal;

        }

    }

}
