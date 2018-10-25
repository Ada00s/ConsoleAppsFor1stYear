using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Excersize18
    {
        public static void MyCode()
        {
            Console.WriteLine("Insert the shopping value");
            string shopping = Console.ReadLine();
            if(!Double.TryParse(shopping, out double shoppingvalue))
            {
                Console.WriteLine("Wrong Input.");
                MyCode();
            }
            
            Console.WriteLine("Insert the customer payment");
            string bills = Console.ReadLine();
            if (!Double.TryParse(bills, out double payment))
            {
                Console.WriteLine("Wrong Input.");
                MyCode();
            }
            else if(payment < shoppingvalue){
                Console.WriteLine("Payment is lower than shopping value");
                MyCode();
            }

            int kr500; int kr200; int kr100; int kr50; int kr20;
            int kr10; int kr5; int kr2; int kr1; int kr05;

            Console.WriteLine("Rest should be like:");
            double rest = payment - shoppingvalue;
            
            kr500 = (int)(rest / 500);
            rest = rest - (kr500 * 500);
            kr200 = (int)(rest / 200);
            rest = rest - (kr200 * 200);
            kr100 = (int)(rest / 100);
            rest = rest - (kr100 * 100);

            kr50 = (int)(rest / 50);
            rest = rest - (kr50 * 50);
            kr20 = (int)(rest / 20);
            rest = rest - (kr20 * 20);

            kr10 = (int)(rest / 10);
            rest = rest - (kr10 * 10);
            kr5 = (int)(rest / 5);
            rest = rest - (kr5 * 5);

            kr2 = (int)(rest / 2);
            rest = rest - (kr2 * 2);
            kr1 = (int)(rest / 1);
            rest = rest - (kr1 * 1);

            kr05 = (int)(rest / 0.5);
            rest = rest - (kr5 * 0.5);

            Console.WriteLine($"Rest in bills:\n500kr: {kr500}, 200kr: {kr200}, 100kr: {kr100}" +
                $" 50kr: {kr50}, 20kr: {kr20}, 10kr: {kr10}, kr5: {kr5}, kr2: {kr2}, " +
                $" 1kr: {kr1}, 50ore: {kr05}");
        }

    }
}
