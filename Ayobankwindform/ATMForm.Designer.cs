namespace Ayobankwindform
{
    partial class ATMForm
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
            groupBox1 = new GroupBox();
            BTNsave = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            TbInput = new TextBox();
            Avgtext = new Label();
            CBoptions = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(BTNsave);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TbInput);
            groupBox1.Controls.Add(Avgtext);
            groupBox1.Controls.Add(CBoptions);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(17, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BTNsave
            // 
            BTNsave.BackColor = Color.RosyBrown;
            BTNsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNsave.ForeColor = Color.DarkSlateGray;
            BTNsave.Location = new Point(263, 252);
            BTNsave.Name = "BTNsave";
            BTNsave.Size = new Size(113, 51);
            BTNsave.TabIndex = 38;
            BTNsave.Text = "Save";
            BTNsave.UseVisualStyleBackColor = false;
            BTNsave.Click += BTNsave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OGNR5748;
            pictureBox1.Location = new Point(47, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(631, 173);
            label7.Name = "label7";
            label7.Size = new Size(28, 28);
            label7.TabIndex = 36;
            label7.Text = "N";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(631, 133);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 35;
            label6.Text = "Debt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(483, 173);
            label5.Name = "label5";
            label5.Size = new Size(28, 28);
            label5.TabIndex = 34;
            label5.Text = "N";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(483, 133);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 33;
            label4.Text = "Current Bal.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(287, 177);
            label2.Name = "label2";
            label2.Size = new Size(32, 31);
            label2.TabIndex = 32;
            label2.Text = "N";
            // 
            // TbInput
            // 
            TbInput.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbInput.ForeColor = Color.Maroon;
            TbInput.Location = new Point(325, 173);
            TbInput.Multiline = true;
            TbInput.Name = "TbInput";
            TbInput.Size = new Size(85, 35);
            TbInput.TabIndex = 31;
            // 
            // Avgtext
            // 
            Avgtext.BackColor = SystemColors.ControlDark;
            Avgtext.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Avgtext.ForeColor = Color.Maroon;
            Avgtext.Location = new Point(25, 98);
            Avgtext.Name = "Avgtext";
            Avgtext.Size = new Size(384, 53);
            Avgtext.TabIndex = 30;
            Avgtext.Text = "What can I help you with ?";
            Avgtext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBoptions
            // 
            CBoptions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBoptions.ForeColor = Color.Maroon;
            CBoptions.FormattingEnabled = true;
            CBoptions.Items.AddRange(new object[] { "Withdraw", "Deposit", "Request for loan" });
            CBoptions.Location = new Point(47, 169);
            CBoptions.MinimumSize = new Size(229, 0);
            CBoptions.Name = "CBoptions";
            CBoptions.Size = new Size(229, 39);
            CBoptions.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(195, 16);
            label3.Name = "label3";
            label3.Size = new Size(409, 62);
            label3.TabIndex = 17;
            label3.Text = "Welcome to AyoBank";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 344);
            Controls.Add(groupBox1);
            Name = "ATMForm";
            Text = "ATMForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox CBoptions;
        private TextBox TBinput;
        private Label label1;
        private TextBox TbInput;
        private Label Avgtext;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Button BTNsave;
    }
}