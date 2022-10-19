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
    public partial class Doubles : Form
    {
        private int computerValue;
        private int userValue;
        Random random = new Random();

        public Doubles()
        {
            InitializeComponent();
           GameDoubles();
        }
        public void GameDoubles()
        {
            computerValue = random.Next(5,20);
            userValue = 0;
            label1_userNamber.Text = $"Ваше число: {userValue++}";
            label1_computerNamber.Text = $"Получите число: {computerValue}";
            
        }
        private void button1_plusOne_Click(object sender, EventArgs e)
        {  
            label1_userNamber.Text = $"Ваше число: {userValue++}";
            GameStop();
        }

        private void button1_multiTwo_Click(object sender, EventArgs e)
        { 
            label1_userNamber.Text = $"Ваше число: {userValue *= 2}";
            GameStop();
        }
        public void GameStop()
        {
            if(computerValue == userValue)
            {
                if (MessageBox.Show("Вы  угадали!!! Хотите повторить?", "МОЛОДЕЦ!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GameDoubles();

                }
                else
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
            else if (computerValue < userValue)
            {
               if( MessageBox.Show("Вы не угадали! Хотите повторить?", ":(",
                   MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    GameDoubles();
                    
                }
                else 
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }

            }


        }



        #region "Lables"
        private void label1_computerNamber_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_userNamber_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
