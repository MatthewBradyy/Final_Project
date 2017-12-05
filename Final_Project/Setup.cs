using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Setup
    {
        public static string lab = "",lab_name="",lab_discription="",lab_code="",lab_run="";
        public static void Get_lab(string lab_number)
        {
            lab = lab_number;
        }
        public static void send_Info()
        {
            //lab 2 Skips this so because the templit is different then the others
            switch (lab)
            {
                case "Lab 1":
                    break;               
                case "Lab 3":
                    break;
                case "Lab 4":
                    break;
                case "Lab 5":
                    break;
                case "Lab 6":
                    break;
                case "Lab 7":
                    break;
                case "Lab 8":
                    break;
                case "Lab 9":
                    break;

            }
        }
    }
}
