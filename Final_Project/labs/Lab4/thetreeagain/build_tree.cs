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
    class build_tree
    {
        
        public List<node> tree = new List<node>();
        private static node root;
        private node focus;
        private node parent;        
        public build_tree()
        {
            root = null;
        }
        public void add(int number)
        {
            focus = root;
            node newnode = new node(number);
            bool added = false;
            //no root in the tree
            if(root == null)
            {
                root = newnode;
                tree.Add(root);
                return;
            }
            else
            {
                
                parent = null;
                while (!added)
                {
                    parent = focus;
                    if(number < focus.node_value)
                    {
                        focus = focus.leftleaf;
                        if(focus == null)
                        {
                            parent.leftleaf = newnode;
                            added = true;
                            tree.Add(parent.leftleaf);
                        }
                    }
                    else
                    {
                        focus = focus.rightleaf;
                        if(focus == null)
                        {
                            parent.rightleaf = newnode;
                            added = true;
                            tree.Add(parent.rightleaf);
                        }
                       
                    }


                }
                
            }
        }
        public void remove(int remove_value)
        {
            int index = -1;           
            index = tree.FindIndex(x => x.node_value == remove_value);
            if(index == -1)
            {
                Console.WriteLine("Number not found");
                Console.ReadLine();
                return;
            }
            else
            {
                DeleteN(root, tree[index]);
                tree.Remove(tree[index]);
            }
        }
        public node DeleteN(node root, node deletenode)
        {
            if(deletenode.node_value < root.node_value)
            {
                root.leftleaf = DeleteN(root.leftleaf, deletenode); 
            }
            if (deletenode.node_value > root.node_value)
            {
                root.rightleaf = DeleteN(root.rightleaf, deletenode);
            }
            else
            {
                //no child
                if((root.rightleaf == null) && (root.leftleaf == null))
                {
                    root = null;
                    return root;
                }
                //has two
                if ((root.rightleaf != null) && (root.leftleaf != null))
                {
                    node nextbiggest = nextsmallest(root.rightleaf);
                    root.node_value = nextbiggest.node_value;
                    root.rightleaf = DeleteN(root.rightleaf, nextbiggest);
                    
                }
                //no left
                else if (root.leftleaf == null)
                {
                    node temp = root;
                    root = root.rightleaf;
                    temp = null;
                }
                //no right
                else if(root.rightleaf == null)
                {
                    node temp = root;
                    root = root.leftleaf;
                    temp = null;
                }               
            }
            return root;
        }
        public node nextsmallest(node rightnode)
        {            
            focus = rightnode;
            do
            {
                if (focus.leftleaf != null)
                {
                    focus = focus.leftleaf;
                }                
            } while (focus.leftleaf != null);
            return focus;
        }
        public void change(int number_change, int change_to)
        {
            int index = -1;
            index = tree.FindIndex(x => x.node_value == number_change);
            if (index == -1)
            {
                Console.WriteLine("Number not found");
                Console.ReadLine();
                return;
            }
            else
            {
                node focusnode = root;
                node parent;
                bool leftchild = true, ischanged = false;
                while (!ischanged)
                {

                    do
                    {
                        parent = focusnode;
                        if (number_change < focusnode.node_value)
                        {
                            leftchild = true;
                            focusnode = focusnode.leftleaf;

                        }
                        else
                        {
                            leftchild = false;
                            focusnode = focusnode.rightleaf;
                        }
                    } while (focusnode.node_value != number_change);
                    if ((focusnode.leftleaf == null) && (focusnode.rightleaf == null))
                    {
                        if (focusnode == root)
                        {
                            if (root.node_value == number_change)
                            {
                                root.node_value = change_to;
                                break;
                            }


                        }
                        else if (leftchild)
                        {
                            if (focusnode.node_value == number_change)
                            {
                                parent.leftleaf.node_value = change_to;

                            }

                        }
                        else
                        {
                            if (focusnode.node_value == number_change)
                            {
                                parent.rightleaf.node_value = change_to;

                            }

                        }
                        ischanged = true;
                        break;
                    }
                    else if (focusnode.rightleaf == null)
                    {
                        if (focusnode == root)
                        {
                            if (root.node_value == number_change)
                            {
                                root.node_value = change_to;
                            }

                        }
                        if (change_to > focusnode.leftleaf.node_value)
                        {
                            if (focusnode.node_value == number_change)
                            {
                                parent.node_value = change_to;
                                break;
                            }

                        }
                        else
                        {
                            remove(number_change);
                            add(change_to);
                        }
                        ischanged = true;
                    }
                    else if (focusnode.leftleaf == null)
                    {
                        if (focusnode == root)
                        {
                            if (root.node_value == number_change)
                            {
                                root.node_value = change_to;
                                break;
                            }

                        }
                        if (change_to <= focusnode.rightleaf.node_value)
                        {
                            if (focusnode.node_value == number_change)
                            {
                                parent.leftleaf.node_value = change_to;
                                break;
                            }

                        }
                        else
                        {
                            remove(number_change);
                            add(change_to);
                        }
                        ischanged = true;
                    }
                    else
                    {
                        if (focusnode == root)
                        {
                            if (root.node_value == number_change)
                            {
                                root.node_value = change_to;
                                break;
                            }

                        }
                        if ((change_to > focusnode.leftleaf.node_value) && (change_to <= focusnode.rightleaf.node_value))
                        {
                            if (focusnode.node_value == number_change)
                            {
                                parent.rightleaf.node_value = change_to;
                                break;
                            }

                        }
                        else
                        {
                            remove(number_change);
                            add(change_to);
                        }
                        ischanged = true;
                    }
                }

            }
        }
        public void print()
        {
            //display(root);
            bool last_node = true;
            root.Print_out("", last_node, root);
        }
        public void display(node N)
        {
            if (N == null)
            {
                return;
            }
            display(N.leftleaf);
            Console.WriteLine(N.node_value);
            display(N.rightleaf);
        }

    }
}
