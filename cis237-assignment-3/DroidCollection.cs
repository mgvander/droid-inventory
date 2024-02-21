using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class DroidCollection
    {
        // Declare array for holding the list of droids
        private Droid[] droids;

        // Declare index of the droids array
        private int droidsIndex;

        /*****************************************************************
         * Constructors
         * **************************************************************/
        public DroidCollection(int passSize)
        {
            // Create an array for droids of all types
            this.droids = new Droid[passSize];

            // Set the index of the array the first index
            // This will be changed as droids are added to the array
            this.droidsIndex = 0;

        }

        /*****************************************************************
         * Methods
         * **************************************************************/
        public void addDroid(Droid passDroid)
        {
            // Add the droid to the first available index
            droids[droidsIndex] = passDroid;

            // Iterate to the next index in the array
            ++droidsIndex;

        }

        public override string ToString()
        {
            return "";

        }

    }

}
