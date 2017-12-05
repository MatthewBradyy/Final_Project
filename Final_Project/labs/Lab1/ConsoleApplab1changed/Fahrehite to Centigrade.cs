using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab1changed
{
    class Fahrehite_to_Centigrade
    {
        public decimal covertfah(decimal unitvalue)
        {
            decimal finalvalue = 0;
            finalvalue = (unitvalue - 32) * (decimal)(5/9);
            return finalvalue;
        }
    }
}
