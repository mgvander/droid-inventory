using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class UserInterface
    {
        /*****************************************************************
         * Methods
         * **************************************************************/
        public void DisplayProgramGreeting()
        {
            // Program Greeting
            Console.WriteLine("Compiling Program...");
            Console.WriteLine("M'um m'aloo.");
            Console.WriteLine("Translating to: GALACTIC BASIC");
            Console.WriteLine("Greetings, Hello.");
            Console.WriteLine("Welcome to the droid cataloging program.");
            Console.WriteLine();

        }

        public string DiplayMenuAndGetInput(string passMenuString)
        {
            // Display Menu
            this.DisplayMenuHeader();
            int numberOfMenuOptionsInteger = this.DisplayMenuOptions(passMenuString);
            
            // Call DiplayInputPrompt() method
            this.DiplayInputPrompt();
            // Call GetUserInput() method
            string choiceString = this.GetUserInput();

            while (!ValidOption(choiceString, numberOfMenuOptionsInteger))
            {
                // Call DiplayInputPrompt() method
                this.DiplayInputPrompt();
                // Call GetUserInput() method
                choiceString = this.GetUserInput();

            }

            return choiceString;

        }

        private void DisplayMenuHeader()
        {
            //
            Console.WriteLine();
            Console.WriteLine("Enter a number from the list of options below.");
            Console.WriteLine("==============================================");

        }

        private int DisplayMenuOptions(string passMenu)
        {
            // Declare number of options in the menu
            int numberOfMenuOptionsInteger;

            //
            switch (passMenu)
            {
                case "Main":
                    // Display menu options
                    Console.WriteLine("1. Add a New Droid");
                    Console.WriteLine("2. Display Inventory");
                    Console.WriteLine("3. Exit the Program");
                    Console.WriteLine();

                    // Set the number of options in the Main Menu
                    numberOfMenuOptionsInteger = 3;

                    break;

                case "Droids":
                    // Display menu options
                    Console.WriteLine("1. Astromech");
                    Console.WriteLine("2. Janitor");
                    Console.WriteLine("3. Protocol");
                    Console.WriteLine("4. Utility");
                    Console.WriteLine();

                    // Set the number of Droid Options Menu
                    numberOfMenuOptionsInteger = 4;

                    break;

                default:
                    //
                    numberOfMenuOptionsInteger = 0;

                    break;

            }

            return numberOfMenuOptionsInteger;

        }

        private void DiplayInputPrompt()
        {
            // Display prompt
            Console.Write("Please enter here >>> ");
            
        }

        private string GetUserInput()
        {
            // Read in user's input
            return Console.ReadLine();

        }

        private bool ValidOption(string passChoiceString, int passMaxNumOptionsInteger)
        {
            // Out of lower bounds to check against
            const int NON_OPTION_INTEGER = 0;

            // Is the user input valid?
            bool isValidBoolean = false;

            try
            {
                // Convert the user choice to integer type
                int choiceInteger = Int32.Parse(passChoiceString);

                // Check that user choice is with in the bounds of the menu
                if (choiceInteger > NON_OPTION_INTEGER && choiceInteger <= passMaxNumOptionsInteger)
                {
                    // The user input it valid
                    isValidBoolean = true;

                }
                else
                {
                    // Display the invalis input error
                    this.DisplayMenuInputErrorMessage(passChoiceString);

                }

            }
            catch(Exception e)
            {
                // Set the variable to false
                isValidBoolean = false;

                // Display exception message
                Console.WriteLine(e.Message);
                Console.WriteLine();

            }

            // Return the state of validity
            return isValidBoolean;

        }

        public void GetNewDroidProperties(string passDroidTypeString)
        {
            //
            switch (passDroidTypeString)
            {
                case "1":
                    // Get astromech droid properties
                    this.GetAstromechProperties();

                    break;

                case "2":
                    // Get janitor droid properties
                    this.GetJanitorProperties();

                    break;

                case "3":
                    // Get protocol droid properties
                    this.GetProtocolProperties();

                    break;

                case "4":
                    // Get utility droid properties
                    this.GetUtilityProperties();

                    break;

            }

        }

        private string[] GetDroidProperties()
        {
            //
            string nameString = this.GetStringProperty("Serial Designation");
            string materialString = this.GetStringProperty("Hull Material");
            string colorString = this.GetStringProperty("Hull Color");

            //
            return new string[] { nameString, materialString, colorString };

        }

        private string[] GetProtocolProperties()
        {
            //
            string[] driodProperties = this.GetDroidProperties();
            string languagesString = this.GetIntegerlProperty("Languages Beyond Binary");

            //
            return new string[] {
                driodProperties[0],
                driodProperties[1],
                driodProperties[2],
                languagesString };

        }

        private string[] GetUtilityProperties()
        {
            //
            string[] driodProperties = this.GetDroidProperties();
            string toolsString = this.GetBoolProperty("a Tool Box");
            string computerConnectionString = this.GetBoolProperty("a Data Probe");
            string scannerString = this.GetBoolProperty("a Scanner Array");

            //
            return new string[] {
                driodProperties[0],
                driodProperties[1],
                driodProperties[2],
                toolsString,
                computerConnectionString,
                scannerString };

        }        

        private string[] GetAstromechProperties()
        {
            //
            string[] utilityProperties = this.GetUtilityProperties();
            string navigationString = this.GetBoolProperty("a Navi-Computer Interface");
            string shipsString = this.GetIntegerlProperty("Ship Interfaces");

            //
            return new string[] {
                utilityProperties[0],
                utilityProperties[1],
                utilityProperties[2],
                utilityProperties[3],
                utilityProperties[4],
                utilityProperties[5],
                navigationString,
                shipsString };

        }

        private string[] GetJanitorProperties()
        {
            //
            string[] utilityProperties = this.GetUtilityProperties();
            string broomString = this.GetBoolProperty("a Broom");
            string vacuumString = this.GetBoolProperty("a Vacuum");

            //
            return new string[] {
                utilityProperties[0],
                utilityProperties[1],
                utilityProperties[2],
                utilityProperties[3],
                utilityProperties[4],
                utilityProperties[5],
                broomString,
                vacuumString };

        }

        private string GetBoolProperty(string passPropertyString)
        {
            //
            bool booleanValueBoolean = false;

            //
            bool validBoolean = false;

            //
            do
            {
                //
                Console.WriteLine($"Is the droid equipped with {passPropertyString}? (Y/N)");

                // Call DiplayInputPrompt() method
                this.DiplayInputPrompt();

                // Call GetUserInput() method
                string inputString = this.GetUserInput();

                if (inputString.ToLower() == "y" || inputString.ToLower() == "n")
                {
                    // If the input is "y" or "Y" then set the value to true
                    // "n" or "N" will set the value to false
                    booleanValueBoolean = (inputString.ToLower() == "y");

                    // The input was valid
                    validBoolean = true;

                }

            } while (!validBoolean);

            //
            return booleanValueBoolean.ToString();

        }

        private string GetIntegerlProperty(string passPropertyString)
        {
            
            //
            string inputString = null;

            //
            int integerValueInteger;
            
            //
            bool validBoolean = false;

            //
            do
            {
                //
                Console.WriteLine($"How many {passPropertyString} is the droid programmed with?");

                // Call DiplayInputPrompt() method
                this.DiplayInputPrompt();

                // Call GetUserInput() method
                inputString = this.GetUserInput();

                //
                try
                {
                    //
                    integerValueInteger = int.Parse(inputString);

                    // The input was valid
                    validBoolean = true;

                }
                catch
                {
                }

            } while (!validBoolean);

            //
            return inputString;

        }

        private string GetStringProperty(string passPropertyString)
        {
            //
            string inputString = null;

            //
            bool validBoolean = false;

            //
            do
            {
                //
                Console.WriteLine($"What is the droid's {passPropertyString}?");

                // Call DiplayInputPrompt() method
                this.DiplayInputPrompt();

                // Call GetUserInput() method
                inputString = this.GetUserInput();

                //
                if (!String.IsNullOrWhiteSpace(inputString))
                {
                    //
                    validBoolean = true;

                }

            } while (!validBoolean);
            

            //
            return inputString;

        }

        private void DisplayMenuInputErrorMessage(string passUserInputString)
        {
            //
            Console.WriteLine($"{passUserInputString} is not a number from the list of options.");
            Console.WriteLine();

        }

    }

}
