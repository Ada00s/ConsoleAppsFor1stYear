using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Excersize17
    {

        public static void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Case 1
            Console.WriteLine("Start of Case 1");
            int c1 = 1;
            while (c1 < 20)
            {
                Console.WriteLine(c1); // Uncomment to see result
                c1 = c1 + 2;
            }
            Console.WriteLine("End of Case 1");


            // Case 2
            Console.WriteLine("Start of Case 2");
            int c2 = 1;
            while (c2 < 20)
            {
                Console.WriteLine(c2); // Uncomment to see result
                c2 = c2 * 2;
            }
            Console.WriteLine("End of Case 2");


            // Case 3
            Console.WriteLine("Start of Case 3");
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10))
            {
                Console.WriteLine(c3);  // Uncomment to see result
                c3++;
            }
            Console.WriteLine("End of Case 3");


            // Case 4
            Console.WriteLine("Start of Case 4");
            int c4 = 10;
            while (c4 >= 0)
            {
                Console.WriteLine(c4);  // Uncomment to see result
                c4--;
            }
            Console.WriteLine("End of Case 4");


            // Insert code for the below four cases

            // Case 5
            int c5 = 1;
            Console.WriteLine("Start of Case 5");
            while (c5 < 9)
            {
                c5 = c5+2;
                Console.WriteLine(c5);
            }
            Console.WriteLine("End of Case 5");
            // Print out the numbers 3,5,7,9


            // Case 6
            Console.WriteLine("Start of Case 6");
            int c6 = 0;
            while (c6 <= 31)
            {
                Console.Write($"{c6}   ");
                c6 = (c6 * 2) + 1;
            }
            Console.WriteLine("\nEnd of Case 6");
            // Print out the numbers 0,1,3,7,15,31


            // Case 7
            Console.WriteLine("Start of Case 7");
            int c7 = 100;
            while (c7 >=1)
            {
                Console.Write($"{c7}   ");
                c7 = c7 / 2;
            }
            Console.WriteLine("\nEnd of Case 7");
            // Print out the numbers 100,50,25,12,6,3,1


            // Case 8 (DIFFICULT)
            Console.WriteLine("Start of Case 8");
            int c8 = 10; int h = 1;
            while (c8!=1)
            {
                c8 = c8 - h;
                h = h * (-1);
                if (h > 0)
                {
                    h = h + 2;
                }
                else
                {
                    h = h - 2;
                }
                Console.Write($"{c8}   ");
            }
            Console.WriteLine("\nEnd of Case 8");
            // Print out the numbers 10,9,12,7,14,5,16,3,18,1


            // The LAST line of code should be ABOVE this line
        }
    }
}
