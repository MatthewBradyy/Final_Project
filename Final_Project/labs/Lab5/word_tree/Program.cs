using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace word_tree
{
    
    class Program
    {
        public static dostuff w = new dostuff();  
        static void Main(string[] args)//main is just to call the other methids i think it looks cleaner this way
        {
            get_list();
            w.diplay();
            w.build_tree();
        }
        public static void get_list()
        {
            //simple grab text then split it in to an array of single strings
            string wordlist  = File.ReadAllText("E:\\Fall 2017\\Data Stutcher\\Labs\\Resourses\\wordlist.txt");
            string[] word = wordlist.Split();
            foreach (string s in word)
            {
                if(s != "")//makes sure no blacks get pust throught
                {
                    w.addword(s, 1);//hit are set to 1 right away because there is at least one of that word there
                }                
            }          
        }
    }
    public class Nodes
    {
        
        public string word;
        public int hits;
        public Nodes leftleaf;
        public Nodes rightleaf;



        public Nodes(string word ,int hits)
        {
            this.word = word;
            this.hits = hits;
        }
        public void Print_out()//what you see in the list part could be better but it works
        {

            
            
            Console.WriteLine(word+ " " + hits);

            var children = new List<Nodes>();
            if (this.leftleaf != null)
            {
                children.Add(this.leftleaf);

            }
            if (this.rightleaf != null)
            {
                children.Add(this.rightleaf);
            }
            for (int i = 0; i < children.Count; i++)
                children[i].Print_out();
        }

    }
    public class dostuff
    {
        public List<Nodes> words = new List<Nodes>();        
        public void addword(string word, int count)
        {
            Nodes add = new Nodes(word, count);//builds the node with the word and its hit
            int index = -1;//index = -1 brcause there is no way to get a nagitive index
            index = words.FindIndex(x => x.word == word);//new thing i learnt is a lambda expression just a way to skinny up the code link to learn it is in my wiki

            if (index == -1)
                words.Add(add);
            else
                words[index].hits++;

        }
        public void diplay()//just put here to show the list in order before ran into the build a tree more for troulbe shooting but i liked it so
            //stayed
        {
            foreach (var w in words)
            {
                Console.WriteLine(w.word + " " + w.hits + " ");
            }
            Console.ReadLine();
        }
        private Nodes root = null;

        public void build_tree()
        {
            foreach (Nodes n in words)
            {
                bool added = false;
                if (root == null)//no root make a root problem solved
                {
                    root = n;                    
                }
                else
                {
                    Nodes focus = root;
                    Nodes parent;
                    while (!added)
                    {
                        //just like my last program runs throw this loop untill the node is added 
                        parent = focus;
                        if (n.hits < focus.hits)//if node hit are less then current node we are looking at go here
                        {
                            focus = focus.leftleaf;
                            if (focus == null)
                            {
                                parent.leftleaf = n;
                                added = true;
                            }
                        }
                        else//greater then or equal go here
                        {
                            focus = focus.rightleaf;
                            if (focus == null)
                            {
                                parent.rightleaf = n;
                                added = true;
                            }
                        }

                    }

                }
            }
            ///clears just to clean things up
            Console.Clear();           
            //starts at the root to run through the print out part of building the tree
            root.Print_out();
            Console.ReadLine();
        
        }
    }

}
