using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_hanoi
{
    class Program
    {
        public static int movemade = 1;
        public static string stack = "ABC", space = " ";
        static void Main(string[] args)
        {
            tower(4, 1,3);
            Console.ReadLine();
        }
        public static void tower(int pieces, int startstack, int endstack)
        {
            if (pieces == 0)
            {
                return;   
            }
            //figures out what the using is
            int usingStack = 6 - startstack - endstack;
            //changes endstack to using
            tower(pieces - 1, startstack, usingStack);
            //Writes you the move the tower lable is taken from the string stacks
            Console.WriteLine(movemade + space + " move " +pieces + " from " + stack[startstack - 1] + " To " + stack[endstack - 1] );
            movemade++;
            // takes out the space so it all stays alined
            if (movemade == 10)
            {
                space = "";
            }
            //Changes sourse to using
            tower(pieces - 1, usingStack, endstack);

        }
    }
}
