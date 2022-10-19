namespace AlexandrAfonin
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Doubles = new System.Windows.Forms.Button();
            this.button1_Nambers = new System.Windows.Forms.Button();
            this.label_Menu = new System.Windows.Forms.Label();
            this.label1_Inform = new System.Windows.Forms.Label();
            this.label1_Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_Doubles
            // 
            this.button1_Doubles.BackColor = System.Drawing.Color.Chocolate;
            this.button1_Doubles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Doubles.Location = new System.Drawing.Point(399, 106);
            this.button1_Doubles.Name = "button1_Doubles";
            this.button1_Doubles.Size = new System.Drawing.Size(207, 112);
            this.button1_Doubles.TabIndex = 0;
            this.button1_Doubles.Text = "УДВОИТЕЛЬ";
            this.button1_Doubles.UseVisualStyleBackColor = false;
            this.button1_Doubles.Click += new System.EventHandler(this.button1_Doubles_Click);
            // 
            // button1_Nambers
            // 
            this.button1_Nambers.BackColor = System.Drawing.Color.CadetBlue;
            this.button1_Nambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Nambers.Location = new System.Drawing.Point(131, 201);
            this.button1_Nambers.Name = "button1_Nambers";
            this.button1_Nambers.Size = new System.Drawing.Size(207, 112);
            this.button1_Nambers.TabIndex = 1;
            this.button1_Nambers.Text = "УГАДАЙ ЧИСЛО";
            this.button1_Nambers.UseVisualStyleBackColor = false;
            this.button1_Nambers.Click += new System.EventHandler(this.button1_Nambers_Click);
            // 
            // label_Menu
            // 
            this.label_Menu.AutoSize = true;
            this.label_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Menu.Location = new System.Drawing.Point(281, 45);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(217, 32);
            this.label_Menu.TabIndex = 2;
            this.label_Menu.Text = "Главное меню\r\n";
            this.label_Menu.Click += new System.EventHandler(this.label_Menu_Click);
            // 
            // label1_Inform
            // 
            this.label1_Inform.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_Inform.Location = new System.Drawing.Point(336, 357);
            this.label1_Inform.Name = "label1_Inform";
            this.label1_Inform.Size = new System.Drawing.Size(465, 84);
            this.label1_Inform.TabIndex = 3;
            this.label1_Inform.Text = "Вы можете поиграть в две игры:  УДВОИТЕЛЬ и УГАДАЙ ЧИСЛО\r\nЦифры будет загадывать " +
    "- ВАШ КОМПЬЮТЕР!  Задача: угадать число!\r\n\r\n  \r\n\r\n\r\n\r\n\r\n";
            this.label1_Inform.Click += new System.EventHandler(this.label1_Inform_Click);
            // 
            // label1_Author
            // 
            this.label1_Author.AutoSize = true;
            this.label1_Author.Location = new System.Drawing.Point(12, 425);
            this.label1_Author.Name = "label1_Author";
            this.label1_Author.Size = new System.Drawing.Size(147, 16);
            this.label1_Author.TabIndex = 4;
            this.label1_Author.Text = "Афонин Александр@\r\n";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_Author);
            this.Controls.Add(this.label1_Inform);
            this.Controls.Add(this.label_Menu);
            this.Controls.Add(this.button1_Nambers);
            this.Controls.Add(this.button1_Doubles);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Doubles;
        private System.Windows.Forms.Button button1_Nambers;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Label label1_Inform;
        private System.Windows.Forms.Label label1_Author;
    }
}

