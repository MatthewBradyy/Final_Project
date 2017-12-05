using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] prime = new int[100];

            for(int i = 1; i <=100; i++)
            {
                prime[i - 1] = i;
            }

            for (int x = 2; x <= 9; x++)
            {
                foreach(int p in prime)
                {
                    if(p == 1)
                        prime[p - 1] = -1;

                    if (p % x == 0 && p != x)
                    {
                        prime[p-1] = -1;
                    }
                }
            }

            foreach(int p in prime)
            {
                if(p != -1)
                {
                    Console.WriteLine(p + "is a prime number");
                }
            }

            Console.ReadLine();


            
        }
    }
}
