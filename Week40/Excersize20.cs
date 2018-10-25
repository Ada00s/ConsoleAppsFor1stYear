using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Excersize20
    {
        public static void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CubeCalculator cc = new CubeCalculator();

            String userInput = cc.GetUserInput("Please enter an integer number:");
            if (userInput == "stop")
            {
                Console.WriteLine("Exc 20 stopped");
            }
            else if (cc.IsANumber(userInput))
            {
                int value = cc.ConvertToNumber(userInput);
                int result = cc.CalculateCube(value);
                Console.WriteLine("The cube of {0} is {1}", value, result);
                MyCode();
            }
            else
            {
                Console.WriteLine("Could not calculate...");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
    
}
