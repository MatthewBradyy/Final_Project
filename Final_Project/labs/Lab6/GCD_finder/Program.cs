using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            get_number();
        }
        static void get_number()
        {
            bool done = false;
            string answer = "y";
            decimal first = 0, second = 0, greater = 0, lesser = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("What is the first number?");
                first = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the second number?");
                second = Convert.ToDecimal(Console.ReadLine());
                //Finds witch number is highest
                if (first > second)
                {
                    greater = first;
                    lesser = second;
                    find_gcd(greater, lesser, -1);
                }
                if (first < second)
                {
                    lesser = first;
                    greater = second;
                    find_gcd(greater,lesser,-1);
                }
                else
                {
                    //numbers that are the same GCD are them selves
                    Console.WriteLine("Your numbers are the same to the GCD is "+ first +"\nDo you want to run again");
                    answer= Console.ReadLine();
                    if(answer.ToLower()== "n")
                    {
                        //Methid to thank the user and close
                        Quit();
                    }                    
                }
            } while (!done);

        }
        static void find_gcd(decimal x,decimal y, decimal remender)
        {
            string again = "y";
            decimal q = 0, r = x;
            int count = 0;
            bool gcd_found = false;
            do
            {
                //find the Q and R the Q is count telling use how many time it goes in to greater r is the remained
                if (r >= y)
                {
                    r = r - y;
                    count++;
                }
                else
                {
                    q = count;
                    Console.WriteLine(x+ "="+ y +"*"+q +"+"+ r);
                    //recycle until r is 0
                    if (r != 0)
                    {
                        find_gcd(y, r, r);
                    }
                    //once r is 0 the GCD was the last r before the 0
                    else
                    {                        
                        Console.WriteLine("your Greatest common devider is " + remender+
                            "\nDo you want to run again?");
                        again = Console.ReadLine();
                        if(again.ToLower() == "y")
                        {
                            get_number();
                        }
                        else
                        {
                            //Methid to thank the user and close
                            Quit();
                        }
                    }                                                 
                }
            } while (!gcd_found);
            
        }
        static void Quit()
        {
            Console.WriteLine("Thank you for Using My GCD Finder");
            Console.Read();
            System.Environment.Exit(-1);
        }
    }

}
