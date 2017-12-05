using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // two array because i have to algarithm
            int[] prime = new int[1000];
            int[] prime2 = new int[1000];
            int x = 0 , count = 0;   
            //something with the stacks
            Stack<int> final = new Stack<int>();
            Stack<int> final2 = new Stack<int>();
            //populates the arrays
            for (int i = 1; i <= 1000; i++)
            {
                prime[i - 1] = i;
                prime2[i - 1] = i;
            }
            //first algurithm based of sieve of eratosthene
            foreach (int n in prime)
            {
                x = n;
                if (n > 1)
                {
                    foreach (int p in prime)
                    {
                        
                        while (p >= x)
                        {
                            
                            if (x == p && p != n)
                            {
                                prime[p - 1] = -1;
                                break;
                            }
                            else
                            {
                                x = x + n;
                            }
                        }

                    }
                } 
                
            }  
            //algurithm using divition 
            for (x = 2; x <= 1000; x++)
            {
                foreach (int p in prime2)
                {
                    if (p % x == 0 && p != x)
                    {
                        prime2[p - 1] = -1;
                    }
                }
            }
            //puplats the stacks
            for (int i = 1000; i >= 1; i--)
            {
                if (prime[i - 1] != -1 && prime[i - 1] != 1)
                {
                    final.Push(prime[i-1]);
                }
                if (prime2[i - 1] != -1 && prime2[i - 1] != 1)
                {
                    final2.Push(prime2[i - 1]);
                }
            }
            //display
            Console.WriteLine("sieve of eratosthene based algorithm");
            foreach(int i in final)
            {                
                Console.Write(i +" ");
                count++;
                if (count == 20)
                {
                    Console.WriteLine();
                    count = 0;
                }

            }
            count = 0;
            Console.WriteLine("\nMy Algorrithum");
            foreach (int i in final2)
            {
                Console.Write(i + " ");
                count++;
                if (count == 20)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
