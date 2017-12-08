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
        public void Get_lab(string lab_number)
        {
            lab = lab_number;
            send_Info();
        }
        public static void send_Info()
        {
            //lab 2 Skips this so because the templit is different then the others
            switch (lab)
            {
                //lab 1 info
                case "Lab 1":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;  
                //lab 3 info    
                case "Lab 3":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 4 info
                case "Lab 4":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 5 info 
                case "Lab 5":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 6 info
                case "Lab 6":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 7 info
                case "Lab 7":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 8 info
                case "Lab 8":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;
                //lab 9 info
                case "Lab 9":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "code location";
                    lab_run = "lab location";
                    break;

            }
            Lab_display f = new Lab_display();
            f.get_info(lab,lab_name, lab_discription, lab_code, lab_run);
            f.Show();
        }
    }
}
