using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Startup
    {
        static void Main(string[] args)
        {

            ExecuteExcersize();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }

        public static void ExecuteExcersize()
        {
            int excno = 0;
            Console.WriteLine("\nWhich exc should be executed?");
            string input = Console.ReadLine();
            if (input != "stop")
            {
                
                try
                {
                    excno = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input should be integer");
                    ExecuteExcersize();
                }
                switch (excno)
                {
                    case 17:
                        Excersize17.MyCode();
                        break;
                    case 18:
                        Excersize18.MyCode();
                        break;
                    case 19:
                        Excersize19.MyCode();
                        break;
                    case 20:
                        Excersize20.MyCode();
                        break;
                    case 21:
                        Excersize21.MyCode();
                        break;
                    default:
                        Console.WriteLine("There are only exc from no 17 to 21");
                        break;
                }
                ExecuteExcersize();
            }
            
        }
    }
}
