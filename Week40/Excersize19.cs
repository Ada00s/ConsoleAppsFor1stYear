using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Excersize19
    {
        public static void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            Console.WriteLine("Shape A:\n");
            for (int i = 0; i < 10; i++)
            {
                DrawingTool.DrawOneStar();
            }

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            Console.WriteLine("\n\nShape B:\n");
            for (int i = 0; i < 10; i++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }
            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            Console.WriteLine("\n\nShape C:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    DrawingTool.DrawOneStar();
                }
                DrawingTool.StartNewLine();
            }

            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //

            Console.WriteLine("\n\nShape D:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j<=i;j++)
                {
                    DrawingTool.DrawOneStar();
                }
                DrawingTool.StartNewLine();
            }

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *
            Console.WriteLine("\n\nShape E:\n");
            for (int i = 0; i < 5; i++)
            {
                for(int k =0; k < i; k++)
                {
                    DrawingTool.DrawOneSpace();
                    
                }
                DrawingTool.DrawOneStar();
                for(int j = 5-i; j>1; j--)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }
                DrawingTool.DrawOneStar();
                DrawingTool.StartNewLine();
            }
            for (int i = 0; i<5; i++)
            {
                for(int k =4-i; k>0; k--)
                {
                    DrawingTool.DrawOneSpace();
                }
                DrawingTool.DrawOneStar();
                for(int j = 0; j<i; j++)
                {
                    for(int x=0; x<2; x++)
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }
                DrawingTool.DrawOneStar();
                DrawingTool.StartNewLine();
            }
            // The LAST line of code should be ABOVE this line

        }
    }
    
}
