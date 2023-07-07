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
            textBoxAttack = new TextBox();
            textBoxSAttack = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AntsSelectorBox = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.BackColor = Color.Red;
            btnAttack.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttack.Location = new Point(72, 408);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(193, 83);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(72, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 154);
            listBox1.TabIndex = 1;
            // 
            // textBoxAttack
            // 
            textBoxAttack.Location = new Point(72, 286);
            textBoxAttack.Name = "textBoxAttack";
            textBoxAttack.Size = new Size(193, 23);
            textBoxAttack.TabIndex = 2;
            textBoxAttack.Text = "1012";
            // 
            // textBoxSAttack
            // 
            textBoxSAttack.Location = new Point(72, 336);
            textBoxSAttack.Name = "textBoxSAttack";
            textBoxSAttack.Size = new Size(193, 23);
            textBoxSAttack.TabIndex = 3;
            textBoxSAttack.Text = "92,6";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SM;
            pictureBox1.Location = new Point(237, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(72, 379);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "damage_bonus";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 268);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 6;
            label1.Text = "Attack Bonus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 318);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 7;
            label2.Text = "Special Ant Skill Attack (Ex. 12,63)";
            // 
            // AntsSelectorBox
            // 
            AntsSelectorBox.FormattingEnabled = true;
            AntsSelectorBox.Items.AddRange(new object[] { "Shikaree Master", "Jack Jumper" });
            AntsSelectorBox.Location = new Point(72, 50);
            AntsSelectorBox.Name = "AntsSelectorBox";
            AntsSelectorBox.Size = new Size(193, 23);
            AntsSelectorBox.TabIndex = 8;
            AntsSelectorBox.Text = "Choose Ant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 23);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Ants List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 541);
            Controls.Add(label3);
            Controls.Add(AntsSelectorBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBoxSAttack);
            Controls.Add(textBoxAttack);
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
        private TextBox textBoxAttack;
        private TextBox textBoxSAttack;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox AntsSelectorBox;
        private Label label3;
    }
}