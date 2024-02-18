namespace ROGUE_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            splitter1 = new Splitter();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 0;
            label1.Text = "AutoClicker";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(473, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 98);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(159, 16);
            label2.TabIndex = 2;
            label2.Text = "Select clickage mode hehe";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDark;
            pictureBox2.Location = new Point(12, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 10);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(352, 93);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 5;
            label3.Text = "BEGIN CLICKAGE";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(352, 93);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 6;
            label4.Text = "ABORT CLICKAGE";
            label4.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(32, 88);
            button2.Name = "button2";
            button2.Size = new Size(87, 25);
            button2.TabIndex = 8;
            button2.Text = "Listening...";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.ForeColor = SystemColors.ButtonShadow;
            button3.Location = new Point(125, 87);
            button3.Name = "button3";
            button3.Size = new Size(87, 25);
            button3.TabIndex = 9;
            button3.Text = "set key...";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 129);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // button4
            // 
            button4.Location = new Point(32, 87);
            button4.Name = "button4";
            button4.Size = new Size(87, 25);
            button4.TabIndex = 11;
            button4.Text = "DetectKey";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 143);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(231, 93);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(602, 143);
            Controls.Add(trackBar1);
            Controls.Add(splitter1);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(label4);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Button button4;
        private Splitter splitter1;
        private TrackBar trackBar1;
    }
}