using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Final_Project
{
    public partial class Lab_display : Form
    {
        public string lab = "", lab_name = "", lab_discription = "", lab_code = "", lab_run = "";
        //runs the exe
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(lab_run);
        }
        //show the code usin the path provided from the setup
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(lab_code);
        }
        //goes back to the lab_sreen and closes the form
        private void button2_Click(object sender, EventArgs e)
        {
            Labs_Screen f = new Labs_Screen();
            Close();
            f.Show();
        }
        //on load the text boxes are filt with the right strings so the user knows what they are looking at
        private void Lab_display_Load(object sender, EventArgs e)
        {
            lbl_LabName.Text = lab_name;
            lbl_LabNumber.Text = lab;
            lbl_discription.Text = lab_discription;
        }

        public Lab_display()
        {
            InitializeComponent();
        }
        //this is where then info is sent 
        public void get_info(string lab,string lab_name,string lab_discription,string lab_code,string lab_run)
        {
            this.lab = lab;
            this.lab_name = lab_name;
            this.lab_discription = lab_discription;
            this.lab_code = lab_code;
            this.lab_run = lab_run;
        }
    }
}
