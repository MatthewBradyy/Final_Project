﻿using System;
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
    public partial class Lab2_from : Form
    {
        public Lab2_from()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Labs_Screen f = new Labs_Screen();
            Close();
            f.Show();
        }

        private void btn_runPart1_Click(object sender, EventArgs e)
        {
            Process.Start("labs\\lab2a.exe"); //relivent path finding it goes from where it is runing and navigates fomr there
        }

        private void btn_codePart1_Click(object sender, EventArgs e)
        {
            Process.Start("labs_code\\lab2a.txt");//relivent path finding it goes from where it is runing and navigates fomr there
        }

        private void btn_runPart2_Click(object sender, EventArgs e)
        {
            Process.Start("labs\\lab2b.exe");//relivent path finding it goes from where it is runing and navigates fomr there
        }

        private void btn_codePart2_Click(object sender, EventArgs e)
        {
            Process.Start("labs_code\\lab2b.txt");//relivent path finding it goes from where it is runing and navigates fomr there
        }
    }
}
