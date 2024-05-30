namespace Ayobankwindform
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
            label1 = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            Tbphysics = new TextBox();
            label3 = new Label();
            avgbutton = new Button();
            Avgtext = new Label();
            Tbenglish = new TextBox();
            Tbfrench = new TextBox();
            Tbmath = new TextBox();
            Tbcivic = new TextBox();
            TbChemistry = new TextBox();
            groupBox2 = new GroupBox();
            btnPlay = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(63, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(69, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 10.2F);
            tbFirstName.Location = new Point(166, 23);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(125, 30);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(0, 0);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(100, 27);
            tbLastName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F);
            btnSave.Location = new Point(231, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(55, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 311);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Bio";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(207, 204);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 30);
            numericUpDown1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(78, 208);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 8;
            label4.Text = "Age:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male", "Bobrisky" });
            comboBox1.Location = new Point(164, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(69, 136);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 6;
            label5.Text = "Gender:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(166, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton2.Location = new Point(19, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chemistry";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton3.Location = new Point(19, 96);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Civic";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton4.Location = new Point(19, 133);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 24);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "Math";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton5.Location = new Point(19, 170);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(82, 24);
            radioButton5.TabIndex = 12;
            radioButton5.TabStop = true;
            radioButton5.Text = "French";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton6.Location = new Point(19, 207);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(85, 24);
            radioButton6.TabIndex = 13;
            radioButton6.TabStop = true;
            radioButton6.Text = "English";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioButton7.Location = new Point(19, 244);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(89, 24);
            radioButton7.TabIndex = 14;
            radioButton7.TabStop = true;
            radioButton7.Text = "Physics";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // Tbphysics
            // 
            Tbphysics.Font = new Font("Microsoft Sans Serif", 10.2F);
            Tbphysics.Location = new Point(131, 251);
            Tbphysics.Name = "Tbphysics";
            Tbphysics.Size = new Size(59, 27);
            Tbphysics.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(33, 22);
            label3.Name = "label3";
            label3.Size = new Size(302, 34);
            label3.TabIndex = 16;
            label3.Text = "Grades";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // avgbutton
            // 
            avgbutton.Font = new Font("Microsoft Sans Serif", 10.2F);
            avgbutton.Location = new Point(232, 262);
            avgbutton.Name = "avgbutton";
            avgbutton.Size = new Size(94, 29);
            avgbutton.TabIndex = 17;
            avgbutton.Text = "Average";
            avgbutton.UseVisualStyleBackColor = true;
            avgbutton.Click += avgbutton_Click;
            // 
            // Avgtext
            // 
            Avgtext.BackColor = SystemColors.ActiveCaption;
            Avgtext.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Avgtext.Location = new Point(232, 127);
            Avgtext.Name = "Avgtext";
            Avgtext.Size = new Size(182, 53);
            Avgtext.TabIndex = 18;
            Avgtext.Text = "Average:";
            Avgtext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tbenglish
            // 
            Tbenglish.Font = new Font("Microsoft Sans Serif", 10.2F);
            Tbenglish.Location = new Point(131, 208);
            Tbenglish.Name = "Tbenglish";
            Tbenglish.Size = new Size(59, 27);
            Tbenglish.TabIndex = 19;
            // 
            // Tbfrench
            // 
            Tbfrench.Font = new Font("Microsoft Sans Serif", 10.2F);
            Tbfrench.Location = new Point(131, 175);
            Tbfrench.Name = "Tbfrench";
            Tbfrench.Size = new Size(59, 27);
            Tbfrench.TabIndex = 20;
            // 
            // Tbmath
            // 
            Tbmath.Font = new Font("Microsoft Sans Serif", 10.2F);
            Tbmath.Location = new Point(131, 137);
            Tbmath.Name = "Tbmath";
            Tbmath.Size = new Size(59, 27);
            Tbmath.TabIndex = 21;
            // 
            // Tbcivic
            // 
            Tbcivic.Font = new Font("Microsoft Sans Serif", 10.2F);
            Tbcivic.Location = new Point(131, 99);
            Tbcivic.Name = "Tbcivic";
            Tbcivic.Size = new Size(59, 27);
            Tbcivic.TabIndex = 22;
            // 
            // TbChemistry
            // 
            TbChemistry.Font = new Font("Microsoft Sans Serif", 10.2F);
            TbChemistry.Location = new Point(131, 61);
            TbChemistry.Name = "TbChemistry";
            TbChemistry.Size = new Size(59, 27);
            TbChemistry.TabIndex = 23;
            TbChemistry.TextChanged += TbChemistry_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TbChemistry);
            groupBox2.Controls.Add(Tbcivic);
            groupBox2.Controls.Add(Tbmath);
            groupBox2.Controls.Add(Tbfrench);
            groupBox2.Controls.Add(Tbenglish);
            groupBox2.Controls.Add(Avgtext);
            groupBox2.Controls.Add(avgbutton);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Tbphysics);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(475, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 311);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Scores";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(730, 366);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 29);
            btnPlay.TabIndex = 7;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(970, 439);
            Controls.Add(btnPlay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Button btnSave;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private TextBox Tbphysics;
        private Label label3;
        private Button avgbutton;
        private Label Avgtext;
        private TextBox Tbenglish;
        private TextBox Tbfrench;
        private TextBox Tbmath;
        private TextBox Tbcivic;
        private TextBox TbChemistry;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnPlay;
        private NumericUpDown numericUpDown1;
        private Label label4;
    }
}
