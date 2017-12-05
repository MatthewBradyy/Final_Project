using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace list_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = File.ReadAllText("E:\\Fall 2017\\Data Stutcher\\Labs\\Resourses\\quote.txt");
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] text = quote.ToCharArray();
            List<char> sorted = new List<char>();
            Console.WriteLine(quote);
            for (int i = 0; i < 52; i++)
            {
                for (int x = 0; x < text.Length; x++)
                {
                    if (i <= 26)
                    {
                        if (text[x].ToString() == letters[i].ToString().ToUpper())
                        {
                            sorted.Add(text[x]);
                            Console.WriteLine(text[x]);
                        }
                    }
                    else
                    {
                        if (text[x].ToString() == letters[i - 26].ToString())
                        {
                            sorted.Add(text[x]);
                            Console.WriteLine(text[x]);
                        }
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
