using System.Diagnostics;

namespace ROGUE_App
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.ForestGreen;
            textBox1.Location = new Point(12, 389);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(609, 110);
            textBox1.TabIndex = 6;
            textBox1.Text = "test / | {} 0*/////|||||\\\\";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuText;
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(273, 33);
            button1.TabIndex = 7;
            button1.Text = "AutoClicker";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(12, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "ROGUE STATUS INFORMATION GOES HERE";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(609, 184);
            textBox2.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuText;
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(12, 51);
            button2.Name = "button2";
            button2.Size = new Size(273, 33);
            button2.TabIndex = 16;
            button2.Text = "Hardware Spoofer";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(633, 515);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Robust OS General Utility Engine -- Made by SpiralSnow";
            Shown += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}