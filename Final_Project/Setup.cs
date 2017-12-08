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
                    lab_code = "labs_code\\lab1.txt";
                    lab_run = "labs\\lab1.exe";
                    break;  
                //lab 3 info    
                case "Lab 3":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab3.txt";
                    lab_run = "labs\\lab3.exe";
                    break;
                //lab 4 info
                case "Lab 4":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab4.txt";
                    lab_run = "labs\\lab4.exe";
                    break;
                //lab 5 info 
                case "Lab 5":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab5.txt";
                    lab_run = "labs\\lab5.exe";
                    break;
                //lab 6 info
                case "Lab 6":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab6.txt";
                    lab_run = "labs\\lab6.exe";
                    break;
                //lab 7 info
                case "Lab 7":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab7.txt";
                    lab_run = "labs\\lab7.exe";
                    break;
                //lab 8 info
                case "Lab 8":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab8.txt";
                    lab_run = "labs\\lab8.exe";
                    break;
                //lab 9 info
                case "Lab 9":
                    lab_name = "name goes here";
                    lab_discription = "discrition goes here";
                    lab_code = "labs_code\\lab9.txt";
                    lab_run = "labs\\lab9.exe";
                    break;

            }
            Lab_display f = new Lab_display();
            f.get_info(lab,lab_name, lab_discription, lab_code, lab_run);
            f.Show();
        }
    }
}
