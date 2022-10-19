using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexandrAfonin
{
    public partial class Numbers : Form
    {
        Random random = new Random();
        int computerNumber;
        int userNumber;
        public Numbers()
        {
            InitializeComponent();
            GameNumbersStart();
        }
        public void GameNumbersStart()
        {
            computerNumber = random.Next(0,100);
        }
        public void GameNumbersContinue()
        {
            textBox1.Text = "";
        }
        public void Analis()
        {
            if (computerNumber == userNumber)
            {
                if (MessageBox.Show("Вы  угадали!!! Хотите повторить?", "МОЛОДЕЦ!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GameNumbersStart();

                }
                else
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
           
            else if (computerNumber < userNumber)
            {
                if (MessageBox.Show("Число больше чем загаданное) Хотите продолжить?", "Не угадал)",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    GameNumbersContinue();

                }
                else
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
            else if (computerNumber > userNumber)
            {
                if (MessageBox.Show("Число меньше чем загаданное) Хотите продолжить?", "Не угадал)",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GameNumbersContinue();

                }
                else
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }





           
        }
        public void NonCorrect()
        {
            MessageBox.Show("Вы ввели некорректное число", "ОШИБКА!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            GameNumbersStart();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (int.TryParse(textBox1.Text, out userNumber))
                {
                    Analis();
                }
                else
                {
                    NonCorrect();
                }
            }
        }
    }
}
