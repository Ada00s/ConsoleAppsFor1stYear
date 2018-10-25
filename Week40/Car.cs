using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Car
    {
        public string Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car()
        {

        }
        public Car(string reg, string br, string mo)
        {
            Registration = reg;
            Brand = br;
            Model = mo;
        }
    }
}
