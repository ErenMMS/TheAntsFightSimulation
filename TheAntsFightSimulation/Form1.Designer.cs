namespace TheAntsFightSimulation
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
            btnAttack = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.BackColor = Color.Red;
            btnAttack.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttack.Location = new Point(79, 290);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(173, 83);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(79, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(173, 154);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(79, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Your Attack Damage";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(79, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Your Spcl. Ant Attack Damage";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SM;
            pictureBox1.Location = new Point(258, -44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 432);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(btnAttack);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAttack;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}