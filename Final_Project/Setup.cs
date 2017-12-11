using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    class Setup
    {
        //this is where the magic happens all the info is past from this class it could of benn done on the lab_screen from but this makes it look cleaner to me 
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
                    lab_name = "Convertoins";
                    lab_discription = "This lab converst units. it has the user choose a unit and then a value.\nafter that is convers them and prints out the convertion";
                    lab_code = "labs_code\\lab1.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab1.exe";      // Added note i figure this out by publishing the program andlooking where it was looking
                    break;                           // i tried a few other relitive file things but they didn't seem to work  
                //lab 3 info    
                case "Lab 3":
                    lab_name = "Letter Sorter";
                    lab_discription = "this is that lab that we were given a quote to sort. the program gets \nthe quote off a text file and then splits it in to chars. after that is done \nit is ran through a loop that sorts it in alphabetical order";
                    lab_code = "labs_code\\lab3.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab3.exe";
                    break;
                //lab 4 info
                case "Lab 4":
                    lab_name = "Binary Tree";
                    lab_discription = "the binary tree lab is just that it build a tree of numbers. this program \nallows you to add remove and change the numbers in the tree";
                    lab_code = "labs_code\\lab4.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab4.exe";
                    break;
                //lab 5 info 
                case "Lab 5":
                    lab_name = "Word tree";
                    lab_discription = "the word tree lab is a program that take a txt file of words and counts how\nmany times a would is repeating in that list. it uses a binary tree to \nsort the information and display it from lease commonto most";
                    lab_code = "labs_code\\lab5.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab5.exe";
                    break;
                //lab 6 info
                case "Lab 6":
                    lab_name = "GCD";
                    lab_discription = "the GCD lab has the user enter two numbers. after the numbers are \ninputter into the program it then finds the gcd of the two numbers";
                    lab_code = "labs_code\\lab6.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab6.exe";
                    break;
                //lab 7 info
                case "Lab 7":
                    lab_name = "Tower of Hanoi";
                    lab_discription = "the Tower of Hanoi is a program that find the best moves to make to \ncomplete this means it is looking for the least amount of move it \ncan make to compete it with out messing up. its uses a simple recertion \nprogram to do this";
                    lab_code = "labs_code\\lab7.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab7.exe";
                    break;
                //lab 8 info
                case "Lab 8":
                    lab_name = "Stack lab";
                    lab_discription = "This lab is just like lab 2 it finds the prime numbers but instead of using\n arrays it uses a stack to hold the prime numbers";
                    lab_code = "labs_code\\lab8.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab8.exe";
                    break;
                //lab 9 info
                case "Lab 9":
                    lab_name = "Sort";
                    lab_discription = "The sort lab is made up of three sorts. it runs all three sorts and times \nthem to see how long it take eo sort a ramdom genarated number list. the \nlist is the same for all the sots just sorted differently and the time taken \nto sort the list is faster and slower dpending on the sort  ";
                    lab_code = "labs_code\\lab9.txt";//relivent path finding it goes from where it is runing and navigates fomr there
                    lab_run = "labs\\lab9.exe";
                    break;

            }
            Lab_display f = new Lab_display();
            //sends the info to the lab_display throught the get_info methid
            f.get_info(lab,lab_name, lab_discription, lab_code, lab_run);
            f.Show();
        }
    }
}
