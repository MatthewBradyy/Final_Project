//
//Matthew Brady
//Data Structures
//Binsry Tree
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thetreeagain
{
    class Program
    {
        public static build_tree thetree = new build_tree();
        static void Main(string[] args)
        {
            //change color of console
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            thetree.add(50);
            thetree.add(55);
            thetree.add(56);
            thetree.add(10);
            thetree.add(53);
            thetree.add(40);
            thetree.add(9);


            menu();

        }
        /// <summary>
        /// area the the user does all the Actions
        /// </summary>
        public static void menu()
        {
            string choise;
            Console.Clear();
            thetree.print();
            Console.WriteLine("Now that we have a tree what do you want to?" +
                "\n\t1. Add number" +
                "\n\t2. remove a number from the list" +
                "\n\t3. Change a number");
            choise = Console.ReadLine();
            if (choise == "1")
            {
                add_new();
            }
            else if (choise == "2")
            {
                remove();
            }
            else if (choise == "3")
            {
                change_number();
            }
            else
            {
                menu();
            }

        }
        public static void add_new()
        {
            string number;
            Console.WriteLine("What number would you like to add?");
            number = Console.ReadLine();
            thetree.add(Convert.ToInt32(number));//runs the add in the tree and simply add number
            menu();

        }
        public static void remove()
        {
            int number;
            Console.WriteLine("What number would you like to remove?");
            number = Convert.ToInt32(Console.ReadLine());
            thetree.remove(number);//sends to the remover and takes out the number that is sent             
            menu();
        }
        public static void change_number()
        {
            int number_remove, number_add;
            Console.WriteLine("What number would you like to change?");
            number_remove = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want to change it to?");
            number_add = Convert.ToInt32(Console.ReadLine());
            thetree.change(number_remove, number_add);//run the change method in build tree

            menu();
        }
    }
}
