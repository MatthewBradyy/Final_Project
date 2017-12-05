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
    public partial class Labs_Screen : Form
    {
        public Labs_Screen()
        {
            InitializeComponent();
        }

        private void btn_lab2_Click(object sender, EventArgs e)
        {
            Lab2_from f = new Lab2_from();
            this.Close();
            f.Show();
        }
    }
}
