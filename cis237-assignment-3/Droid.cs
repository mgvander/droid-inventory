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
        //
        private const int NUMBER_OF_MATERIALS = 9;

        //
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

        //
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

        //
        public abstract string Model { get; }

        //
        public string[] Materials
        {
            get { return this._materials; }
        }

        //
        public decimal[] MaterialPrices
        {
            get { return this._materialPrices; }
        }

        //
        public string Material
        {
            get { return _materialString; }
        }
        
        /*****************************************************************
         * Methods
         * **************************************************************/
        
        public virtual void CalculateTotalCost()
        {
            //
            this.TotalCost += this.CalculateMaterialCost();

        }

        public override string ToString()
        {
            //
            decimal totalMaterialCost = this.CalculateMaterialCost();

            //
            return "Serial Designation:".PadRight(25) + $"{this._serialDesignationString}" + Environment.NewLine +
                "Hull Material:".PadRight(25) + $"{this._materialString}".PadRight(14) + $"+ {totalMaterialCost} Galactic Credits" + Environment.NewLine +
                "Hull Color:".PadRight(25) + $"{this._colorString}" + Environment.NewLine;

        }

        protected decimal CalculateMaterialCost()
        {
            //
            int materialIndexInteger = 0;

            //
            if (this.Material != null)
            {
                //
                for (int indexInteger = 0; indexInteger < this.Materials.Length; ++indexInteger)
                {
                    //
                    if (string.Equals(this.Materials[indexInteger], this.Material))
                    {
                        //
                        materialIndexInteger = indexInteger;

                        //
                        indexInteger = this.Materials.Length;

                    }

                }

            }

            return this.MaterialPrices[materialIndexInteger];

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
