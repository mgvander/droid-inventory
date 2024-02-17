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
         * Properties
         * **************************************************************/
        // Total cost of a droid
        public decimal TotalCost { get; set; }

        //
        private string Material { get; set; }

        //
        private string Color { get; set; }

        /*****************************************************************
         * Constructors
         * **************************************************************/
        protected Droid()
        {

        }

        /*****************************************************************
         * Methods
         * **************************************************************/
        /// <summary>
        /// 
        /// </summary>
        public void CalculateTotalCost()
        {

        }

        private void ToString()
        {

        }

    }

}
