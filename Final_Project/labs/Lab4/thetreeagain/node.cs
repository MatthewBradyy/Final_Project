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
    class node
    {
        public int node_value;
        public node rightleaf;
        public node leftleaf;
        public node(int value)
        {
            node_value = value;
        }
        public node root;
        public void Print_out(string indent, bool last, node node)//what you see in the list.
        {


            Console.Write(indent);
            if (last)
            {
                Console.Write("╚═►");
                indent += "  ";
            }
            else
            {
                Console.Write("╠═►");
                indent += "║ ";
            }
            Console.WriteLine(node_value);

            var children = new List<node>();//this is a hard one to explain to sum it up it looks at each child or leaf in the node
            //then looks at its childent if they have them it is put into a list for that child and the list is then work through
            if (this.leftleaf != null)
            {
                children.Add(this.leftleaf);

            }
            if (this.rightleaf != null)
            {
                children.Add(this.rightleaf);
            }
            for (int i = 0; i < children.Count; i++)
                children[i].Print_out(indent, i == children.Count - 1, null);//if the i == children.count - 1 is true that meeans it hit the last child so the computer will
                                                                             //print out the last indent type witch it╚═► 

        }
    }
}
