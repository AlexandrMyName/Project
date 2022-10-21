using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class TrueFalse : Form
    {
        public TrueFalse()
        {
            InitializeComponent();
        }
        Engine engine;
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    engine = new Engine(dlg.FileName);
                    engine.Add("Земля круглая?", true);
                    engine.Save();
                    numericUpDown_Number.Maximum = 1;
                    numericUpDown_Number.Minimum = 1;
                    numericUpDown_Number.Value = 1;

                }
            }
            catch { MessageBox.Show("Выбран не тот объект!", "ОШИБКА!"); }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                try {
                    engine = new Engine(dlg.FileName);
                    engine.Load();
                    numericUpDown_Number.Minimum = 1;
                    numericUpDown_Number.Maximum = engine.Count;
                    numericUpDown_Number.Value = 1;
                }
                catch { MessageBox.Show("База данных не обнаружена!","ОШИБКА!"); }
                
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            if(engine != null)
                engine.Save();
           else
                { MessageBox.Show("Нет базы данных, чтобы сохранить!", "ОШИБКА!"); }
            
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
                if(engine != null)
                {
                    engine.Add($"#{engine.Count + 1}", true);
                    numericUpDown_Number.Maximum = engine.Count;
                    numericUpDown_Number.Value = engine.Count;
                }
               else
                { MessageBox.Show("Нет базы данных, некуда добавить!", "ОШИБКА!"); }
            
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(engine != null && numericUpDown_Number.Value>1)
            {
                engine.Remove((int)numericUpDown_Number.Value - 1);
                numericUpDown_Number.Maximum--;
                numericUpDown_Number.Value--;
            }else
            { MessageBox.Show("База данных пуста!", "ОШИБКА!"); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { if(engine != null)
            {
                engine[(int)numericUpDown_Number.Value - 1].TrueFalse = checkBox_True.Checked;
                engine[(int)numericUpDown_Number.Value - 1].Text = textBoxMy.Text;
            }
            else
            { MessageBox.Show("Нет базы данных!", "ОШИБКА!"); }

        }

        private void numericUpDown_Number_ValueChanged(object sender, EventArgs e)
        {
            if(engine != null)
            {
                textBoxMy.Text = engine[(int)numericUpDown_Number.Value - 1].Text;
                checkBox_True.Checked = engine[(int)numericUpDown_Number.Value - 1].TrueFalse;
            }
            else
            { MessageBox.Show("Нет базы данных!", "ОШИБКА!"); }

        }

        private void MenuAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Афонин Александр Игоревич", "Версия 1.0.1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
