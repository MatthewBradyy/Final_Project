using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab1changed
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            do
            {
                Console.Clear();
                decimal unitvalue = 0, finalvalue = 0;
                string unit = "", convertunit = "";
                char choose = ' ';
                Console.WriteLine("Please choose a starting unit");
                Console.WriteLine("1. Ounces \n2. feet \n3. Fahrehite");
                choose = Convert.ToChar(Console.ReadLine());
                switch (choose)
                {
                    case '1':
                        unit = "Ounces";
                        convertunit = "Grams";
                        break;
                    case '2':
                        unit = "FEET";
                        convertunit = "Centimeters";
                        break;
                    case '3':
                        unit = "Fahrehite";
                        convertunit = "Centigride";
                        break;
                    default:
                        return;
                }
                Console.WriteLine("How many {0} would you like to convert to {1}", unit, convertunit);
                unitvalue = Convert.ToDecimal(Console.ReadLine());
                Oz_to_Grams OtG = new Oz_to_Grams();
                Fahrehite_to_Centigrade FtC = new Fahrehite_to_Centigrade();
                Feet_to_Centimeters feet = new Feet_to_Centimeters();

                switch (choose)
                {
                    case '1':
                        OtG.unit_value = unitvalue;
                        Console.WriteLine(unitvalue + " " + unit + " equals " + OtG.covertOz() + " " + convertunit);
                        break;
                    case '2':
                        feet.unit_value = unitvalue;
                        Console.WriteLine(unitvalue + " " + unit + " equals " + feet.covertfeet() + " " + convertunit);
                                                
                        break;
                    case '3':
                        finalvalue = FtC.covertfah(unitvalue);
                        Console.WriteLine(unitvalue + " " + unit + " equals " + finalvalue + " " + convertunit);
                        break;
                    default:
                        return;
                }
                
                do
                {
                    Console.WriteLine("do you want continue (y/n) ");
                    cont =Console.ReadLine();
                } while (cont.ToLower() != "n" && cont.ToLower() != "y");
               
            } while (cont.ToLower() != "n");

        }
        
    }
}
