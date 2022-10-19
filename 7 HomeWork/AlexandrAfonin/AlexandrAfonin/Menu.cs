using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlexandrAfonin
{
    public partial class Menu : Form
    {
        


        public  Menu()
        {
            InitializeComponent();

        }

        private void label_Menu_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Inform_Click(object sender, EventArgs e)
        {

        }

        private void button1_Doubles_Click(object sender, EventArgs e)
        {
            
            Doubles play_doubles = new Doubles();
            this.Hide();
            play_doubles.ShowDialog();
            Close();
           
            
        }

        private void button1_Nambers_Click(object sender, EventArgs e)
        {
            Numbers play_numbers = new Numbers();
            this.Hide();
            play_numbers.ShowDialog();
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }

    



}
