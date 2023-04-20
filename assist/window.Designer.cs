namespace assist
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(341, 389);
            button1.Name = "button1";
            button1.Size = new Size(188, 43);
            button1.TabIndex = 0;
            button1.Text = "GTA 5";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 389);
            button2.Name = "button2";
            button2.Size = new Size(188, 43);
            button2.TabIndex = 1;
            button2.Text = "Cheat Engine";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(178, 320);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 2;
            button3.Text = "Scan";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(178, 129);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Custom App Name";
            textBox1.Size = new Size(188, 24);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 380);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(178, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 109);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(178, 274);
            button4.Name = "button4";
            button4.Size = new Size(122, 40);
            button4.TabIndex = 6;
            button4.Text = "Kill";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(309, 274);
            button5.Name = "button5";
            button5.Size = new Size(57, 86);
            button5.TabIndex = 7;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(491, 12);
            button6.Name = "button6";
            button6.Size = new Size(38, 27);
            button6.TabIndex = 8;
            button6.Text = "help";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // window
            // 
            AcceptButton = button4;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(541, 444);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "window";
            Text = "Process Killer";
            Load += window_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void window_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        public ListBox listBox1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}