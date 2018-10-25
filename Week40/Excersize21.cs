using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Excersize21
    {
        public static void MyCode()
        {
            Car[] cars =
            {
                new Car("ZGH 4123", "Mercedes", "Benz"),
                new Car("WRW 1232", "Ferrari", "Testarossa"),
                new Car("TKN 6456", "Audi", "dunnoAny"),
                new Car("POK h7sd", "Skoda", "Fabia"),
                new Car("LU 7GX8", "Porsche", "Panamera")
            };

            for(int i =0; i<cars.Length; i++)
            {
                Console.WriteLine($"Car: {cars[i].Brand} {cars[i].Model} with regNo: {cars[i].Registration}");
            }
            //Better approach:

            //foreach(Car c in cars)
            //{
            //    Console.WriteLine($"Car: {c.Brand} {c.Model} with regNO: {c.Registration}");
            //}
        }
    }
}
