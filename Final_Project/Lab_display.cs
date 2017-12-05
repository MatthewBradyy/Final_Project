using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Lab_display : Form
    {
        public string lab = "", lab_name = "", lab_discription = "", lab_code = "", lab_run = "";

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
