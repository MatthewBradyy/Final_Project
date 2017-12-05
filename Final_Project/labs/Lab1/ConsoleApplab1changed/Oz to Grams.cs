using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab1changed
{
    class Oz_to_Grams
    {
        public decimal unit_value;
        public decimal covertOz()
        {
            return (this.unit_value * (decimal)28.349495231d );
            
        }
    }
}
