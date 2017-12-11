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
            //lab to is different then to other lab because it has to parts so i made its own screeen
            Lab2_from f = new Lab2_from();
            this.Close();
            f.Show();
        }
        private void lab_choose_btn(object sender, EventArgs e)
        {
            //Creats a object so that the text on the butten can be sent making it so i only neeed on event handler
            Button clickedButton = (Button)sender;                 
            Setup s = new Setup();
            Close();
            s.Get_lab(clickedButton.Text.ToString());
        }
        
    }
}
