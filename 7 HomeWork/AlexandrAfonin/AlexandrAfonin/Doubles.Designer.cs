namespace AlexandrAfonin
{
    partial class Doubles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_plusOne = new System.Windows.Forms.Button();
            this.button1_multiTwo = new System.Windows.Forms.Button();
            this.label1_computerNamber = new System.Windows.Forms.Label();
            this.label1_userNamber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_plusOne
            // 
            this.button1_plusOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_plusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_plusOne.Location = new System.Drawing.Point(564, 72);
            this.button1_plusOne.Name = "button1_plusOne";
            this.button1_plusOne.Size = new System.Drawing.Size(150, 60);
            this.button1_plusOne.TabIndex = 0;
            this.button1_plusOne.Text = "+1";
            this.button1_plusOne.UseVisualStyleBackColor = false;
            this.button1_plusOne.Click += new System.EventHandler(this.button1_plusOne_Click);
            // 
            // button1_multiTwo
            // 
            this.button1_multiTwo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1_multiTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_multiTwo.Location = new System.Drawing.Point(346, 72);
            this.button1_multiTwo.Name = "button1_multiTwo";
            this.button1_multiTwo.Size = new System.Drawing.Size(150, 60);
            this.button1_multiTwo.TabIndex = 1;
            this.button1_multiTwo.Text = "*2";
            this.button1_multiTwo.UseVisualStyleBackColor = false;
            this.button1_multiTwo.Click += new System.EventHandler(this.button1_multiTwo_Click);
            // 
            // label1_computerNamber
            // 
            this.label1_computerNamber.AutoSize = true;
            this.label1_computerNamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_computerNamber.Location = new System.Drawing.Point(12, 262);
            this.label1_computerNamber.Name = "label1_computerNamber";
            this.label1_computerNamber.Size = new System.Drawing.Size(355, 25);
            this.label1_computerNamber.TabIndex = 2;
            this.label1_computerNamber.Text = "Число загаданное компьютером:";
            this.label1_computerNamber.Click += new System.EventHandler(this.label1_computerNamber_Click);
            // 
            // label1_userNamber
            // 
            this.label1_userNamber.AutoSize = true;
            this.label1_userNamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_userNamber.Location = new System.Drawing.Point(229, 194);
            this.label1_userNamber.Name = "label1_userNamber";
            this.label1_userNamber.Size = new System.Drawing.Size(138, 25);
            this.label1_userNamber.TabIndex = 3;
            this.label1_userNamber.Text = "Ваше число:";
            this.label1_userNamber.Click += new System.EventHandler(this.label1_userNamber_Click);
            // 
            // Doubles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_userNamber);
            this.Controls.Add(this.label1_computerNamber);
            this.Controls.Add(this.button1_multiTwo);
            this.Controls.Add(this.button1_plusOne);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Doubles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_plusOne;
        private System.Windows.Forms.Button button1_multiTwo;
        private System.Windows.Forms.Label label1_computerNamber;
        private System.Windows.Forms.Label label1_userNamber;
    }
}