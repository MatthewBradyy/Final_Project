using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab1changed
{
    class Feet_to_Centimeters
    {
        public decimal unit_value;
        public decimal covertfeet()
        {
            return (this.unit_value * (decimal)28.349495231d);
            
        }
    }
}
