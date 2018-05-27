namespace DesktopApp2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.matkBox = new System.Windows.Forms.TextBox();
            this.wepdBox = new System.Windows.Forms.TextBox();
            this.chrgBox = new System.Windows.Forms.TextBox();
            this.mdefBox = new System.Windows.Forms.TextBox();
            this.armourBox = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.moraleBox = new System.Windows.Forms.TextBox();
            this.mdefs = new System.Windows.Forms.TextBox();
            this.arms = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.matkb = new System.Windows.Forms.TextBox();
            this.wepdb = new System.Windows.Forms.TextBox();
            this.chrgb = new System.Windows.Forms.TextBox();
            this.mdefb = new System.Windows.Forms.TextBox();
            this.armb = new System.Windows.Forms.TextBox();
            this.moraleb = new System.Windows.Forms.TextBox();
            this.matk_r = new System.Windows.Forms.TextBox();
            this.wepd_r = new System.Windows.Forms.TextBox();
            this.chrg_r = new System.Windows.Forms.TextBox();
            this.mdef_r = new System.Windows.Forms.TextBox();
            this.armour_r = new System.Windows.Forms.TextBox();
            this.morale_r = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 72);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Calculate Chevrones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(143, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Melee Defense ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(143, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Melee Attack";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(143, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Morale";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox1.HideSelection = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 12);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.RejectInputOnFirstFailure = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.Text = "Base Stats";
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Enabled = false;
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(143, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Unit exp level";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 38);
            this.textBox5.MaxLength = 3;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyUp);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(249, 65);
            this.textBox6.MaxLength = 3;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyUp);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(249, 91);
            this.textBox7.MaxLength = 3;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(61, 20);
            this.textBox7.TabIndex = 3;
            this.textBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyUp);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(249, 116);
            this.textBox8.MaxLength = 1;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 20);
            this.textBox8.TabIndex = 4;
            this.textBox8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyUp);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.maskedTextBox2.HideSelection = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(316, 12);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.RejectInputOnFirstFailure = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.TabStop = false;
            this.maskedTextBox2.Text = "New base";
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(316, 38);
            this.textBox9.MaxLength = 3;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(316, 64);
            this.textBox10.MaxLength = 3;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(316, 91);
            this.textBox11.MaxLength = 3;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(60, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 72);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "Calculate Bonuses";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 20);
            this.button3.TabIndex = 12;
            this.button3.TabStop = false;
            this.button3.Text = "Import chevrones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox12.Enabled = false;
            this.textBox12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox12.Location = new System.Drawing.Point(143, 333);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 14;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Morale";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox13.Enabled = false;
            this.textBox13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox13.Location = new System.Drawing.Point(143, 203);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 15;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Melee Attack";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox14.Enabled = false;
            this.textBox14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox14.Location = new System.Drawing.Point(143, 281);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 16;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "Melee Defense ";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox15.Enabled = false;
            this.textBox15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox15.Location = new System.Drawing.Point(143, 255);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 17;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "Charge bonus";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox16.Enabled = false;
            this.textBox16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox16.Location = new System.Drawing.Point(143, 307);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 18;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Armour";
            // 
            // matkBox
            // 
            this.matkBox.Location = new System.Drawing.Point(249, 203);
            this.matkBox.MaxLength = 3;
            this.matkBox.Name = "matkBox";
            this.matkBox.Size = new System.Drawing.Size(61, 20);
            this.matkBox.TabIndex = 5;
            this.matkBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.matkBox_KeyUp);
            // 
            // wepdBox
            // 
            this.wepdBox.Location = new System.Drawing.Point(249, 229);
            this.wepdBox.MaxLength = 3;
            this.wepdBox.Name = "wepdBox";
            this.wepdBox.Size = new System.Drawing.Size(61, 20);
            this.wepdBox.TabIndex = 6;
            this.wepdBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.wepdBox_KeyUp);
            // 
            // chrgBox
            // 
            this.chrgBox.Location = new System.Drawing.Point(249, 255);
            this.chrgBox.MaxLength = 3;
            this.chrgBox.Name = "chrgBox";
            this.chrgBox.Size = new System.Drawing.Size(61, 20);
            this.chrgBox.TabIndex = 7;
            this.chrgBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chrgBox_KeyUp);
            // 
            // mdefBox
            // 
            this.mdefBox.Location = new System.Drawing.Point(249, 281);
            this.mdefBox.MaxLength = 3;
            this.mdefBox.Name = "mdefBox";
            this.mdefBox.Size = new System.Drawing.Size(61, 20);
            this.mdefBox.TabIndex = 8;
            this.mdefBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdefBox_KeyUp);
            // 
            // armourBox
            // 
            this.armourBox.Location = new System.Drawing.Point(249, 307);
            this.armourBox.MaxLength = 3;
            this.armourBox.Name = "armourBox";
            this.armourBox.Size = new System.Drawing.Size(61, 20);
            this.armourBox.TabIndex = 9;
            this.armourBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.armourBox_KeyUp);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox22.Enabled = false;
            this.textBox22.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox22.Location = new System.Drawing.Point(143, 229);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 24;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "Weapon Damage";
            // 
            // moraleBox
            // 
            this.moraleBox.Location = new System.Drawing.Point(249, 333);
            this.moraleBox.MaxLength = 3;
            this.moraleBox.Name = "moraleBox";
            this.moraleBox.Size = new System.Drawing.Size(61, 20);
            this.moraleBox.TabIndex = 10;
            this.moraleBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.moraleBox_KeyUp);
            // 
            // mdefs
            // 
            this.mdefs.Location = new System.Drawing.Point(316, 281);
            this.mdefs.MaxLength = 3;
            this.mdefs.Name = "mdefs";
            this.mdefs.Size = new System.Drawing.Size(61, 20);
            this.mdefs.TabIndex = 25;
            this.mdefs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdefs_KeyUp);
            // 
            // arms
            // 
            this.arms.Location = new System.Drawing.Point(316, 307);
            this.arms.MaxLength = 3;
            this.arms.Name = "arms";
            this.arms.Size = new System.Drawing.Size(61, 20);
            this.arms.TabIndex = 26;
            this.arms.KeyUp += new System.Windows.Forms.KeyEventHandler(this.arms_KeyUp);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.White;
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox3.Enabled = false;
            this.maskedTextBox3.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox3.HideSelection = false;
            this.maskedTextBox3.Location = new System.Drawing.Point(143, 177);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.RejectInputOnFirstFailure = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 27;
            this.maskedTextBox3.TabStop = false;
            this.maskedTextBox3.Text = "Base Stats";
            this.maskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.White;
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox4.Enabled = false;
            this.maskedTextBox4.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox4.HideSelection = false;
            this.maskedTextBox4.Location = new System.Drawing.Point(316, 177);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.RejectInputOnFirstFailure = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox4.TabIndex = 28;
            this.maskedTextBox4.TabStop = false;
            this.maskedTextBox4.Text = "Shield";
            this.maskedTextBox4.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.Color.White;
            this.maskedTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox5.Enabled = false;
            this.maskedTextBox5.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox5.HideSelection = false;
            this.maskedTextBox5.Location = new System.Drawing.Point(249, 177);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.RejectInputOnFirstFailure = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox5.TabIndex = 29;
            this.maskedTextBox5.TabStop = false;
            this.maskedTextBox5.Text = "Value";
            this.maskedTextBox5.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BackColor = System.Drawing.Color.White;
            this.maskedTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox6.Enabled = false;
            this.maskedTextBox6.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox6.HideSelection = false;
            this.maskedTextBox6.Location = new System.Drawing.Point(249, 12);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.ReadOnly = true;
            this.maskedTextBox6.RejectInputOnFirstFailure = true;
            this.maskedTextBox6.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox6.TabIndex = 30;
            this.maskedTextBox6.TabStop = false;
            this.maskedTextBox6.Text = "Value";
            this.maskedTextBox6.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.BackColor = System.Drawing.Color.White;
            this.maskedTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox7.Enabled = false;
            this.maskedTextBox7.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox7.HideSelection = false;
            this.maskedTextBox7.Location = new System.Drawing.Point(463, 177);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.ReadOnly = true;
            this.maskedTextBox7.RejectInputOnFirstFailure = true;
            this.maskedTextBox7.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox7.TabIndex = 31;
            this.maskedTextBox7.TabStop = false;
            this.maskedTextBox7.Text = "Result";
            this.maskedTextBox7.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.BackColor = System.Drawing.Color.White;
            this.maskedTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox8.Enabled = false;
            this.maskedTextBox8.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox8.HideSelection = false;
            this.maskedTextBox8.Location = new System.Drawing.Point(383, 177);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.ReadOnly = true;
            this.maskedTextBox8.RejectInputOnFirstFailure = true;
            this.maskedTextBox8.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox8.TabIndex = 32;
            this.maskedTextBox8.TabStop = false;
            this.maskedTextBox8.Text = "Bonuses in %";
            this.maskedTextBox8.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // matkb
            // 
            this.matkb.Location = new System.Drawing.Point(383, 203);
            this.matkb.MaxLength = 3;
            this.matkb.Name = "matkb";
            this.matkb.Size = new System.Drawing.Size(74, 20);
            this.matkb.TabIndex = 33;
            this.matkb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.matkb_KeyUp);
            // 
            // wepdb
            // 
            this.wepdb.Location = new System.Drawing.Point(383, 229);
            this.wepdb.MaxLength = 3;
            this.wepdb.Name = "wepdb";
            this.wepdb.Size = new System.Drawing.Size(74, 20);
            this.wepdb.TabIndex = 34;
            this.wepdb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.wepdb_KeyUp);
            // 
            // chrgb
            // 
            this.chrgb.Location = new System.Drawing.Point(383, 254);
            this.chrgb.MaxLength = 3;
            this.chrgb.Name = "chrgb";
            this.chrgb.Size = new System.Drawing.Size(74, 20);
            this.chrgb.TabIndex = 35;
            this.chrgb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chrgb_KeyUp);
            // 
            // mdefb
            // 
            this.mdefb.Location = new System.Drawing.Point(383, 280);
            this.mdefb.MaxLength = 3;
            this.mdefb.Name = "mdefb";
            this.mdefb.Size = new System.Drawing.Size(74, 20);
            this.mdefb.TabIndex = 36;
            this.mdefb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdefb_KeyUp);
            // 
            // armb
            // 
            this.armb.Location = new System.Drawing.Point(383, 307);
            this.armb.MaxLength = 3;
            this.armb.Name = "armb";
            this.armb.Size = new System.Drawing.Size(74, 20);
            this.armb.TabIndex = 37;
            this.armb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.armb_KeyUp);
            // 
            // moraleb
            // 
            this.moraleb.Location = new System.Drawing.Point(383, 333);
            this.moraleb.MaxLength = 3;
            this.moraleb.Name = "moraleb";
            this.moraleb.Size = new System.Drawing.Size(74, 20);
            this.moraleb.TabIndex = 38;
            this.moraleb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.moraleb_KeyUp);
            // 
            // matk_r
            // 
            this.matk_r.Enabled = false;
            this.matk_r.Location = new System.Drawing.Point(463, 203);
            this.matk_r.MaxLength = 3;
            this.matk_r.Name = "matk_r";
            this.matk_r.Size = new System.Drawing.Size(60, 20);
            this.matk_r.TabIndex = 39;
            this.matk_r.TabStop = false;
            // 
            // wepd_r
            // 
            this.wepd_r.Enabled = false;
            this.wepd_r.Location = new System.Drawing.Point(463, 229);
            this.wepd_r.MaxLength = 3;
            this.wepd_r.Name = "wepd_r";
            this.wepd_r.Size = new System.Drawing.Size(60, 20);
            this.wepd_r.TabIndex = 40;
            this.wepd_r.TabStop = false;
            // 
            // chrg_r
            // 
            this.chrg_r.Enabled = false;
            this.chrg_r.Location = new System.Drawing.Point(463, 255);
            this.chrg_r.MaxLength = 3;
            this.chrg_r.Name = "chrg_r";
            this.chrg_r.Size = new System.Drawing.Size(60, 20);
            this.chrg_r.TabIndex = 41;
            this.chrg_r.TabStop = false;
            // 
            // mdef_r
            // 
            this.mdef_r.Enabled = false;
            this.mdef_r.Location = new System.Drawing.Point(463, 280);
            this.mdef_r.MaxLength = 3;
            this.mdef_r.Name = "mdef_r";
            this.mdef_r.Size = new System.Drawing.Size(60, 20);
            this.mdef_r.TabIndex = 42;
            this.mdef_r.TabStop = false;
            // 
            // armour_r
            // 
            this.armour_r.Enabled = false;
            this.armour_r.Location = new System.Drawing.Point(463, 307);
            this.armour_r.MaxLength = 3;
            this.armour_r.Name = "armour_r";
            this.armour_r.Size = new System.Drawing.Size(60, 20);
            this.armour_r.TabIndex = 43;
            this.armour_r.TabStop = false;
            // 
            // morale_r
            // 
            this.morale_r.Enabled = false;
            this.morale_r.Location = new System.Drawing.Point(463, 333);
            this.morale_r.MaxLength = 3;
            this.morale_r.Name = "morale_r";
            this.morale_r.Size = new System.Drawing.Size(60, 20);
            this.morale_r.TabIndex = 44;
            this.morale_r.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 395);
            this.Controls.Add(this.morale_r);
            this.Controls.Add(this.armour_r);
            this.Controls.Add(this.mdef_r);
            this.Controls.Add(this.chrg_r);
            this.Controls.Add(this.wepd_r);
            this.Controls.Add(this.matk_r);
            this.Controls.Add(this.moraleb);
            this.Controls.Add(this.armb);
            this.Controls.Add(this.mdefb);
            this.Controls.Add(this.chrgb);
            this.Controls.Add(this.wepdb);
            this.Controls.Add(this.matkb);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.arms);
            this.Controls.Add(this.mdefs);
            this.Controls.Add(this.moraleBox);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.armourBox);
            this.Controls.Add(this.mdefBox);
            this.Controls.Add(this.chrgBox);
            this.Controls.Add(this.wepdBox);
            this.Controls.Add(this.matkBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.MaskedTextBox maskedTextBox2;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox textBox10;
        public System.Windows.Forms.TextBox textBox11;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        public System.Windows.Forms.TextBox matkBox;
        public System.Windows.Forms.TextBox wepdBox;
        public System.Windows.Forms.TextBox chrgBox;
        public System.Windows.Forms.TextBox mdefBox;
        public System.Windows.Forms.TextBox armourBox;
        private System.Windows.Forms.TextBox textBox22;
        public System.Windows.Forms.TextBox moraleBox;
        public System.Windows.Forms.TextBox mdefs;
        public System.Windows.Forms.TextBox arms;
        public System.Windows.Forms.MaskedTextBox maskedTextBox3;
        public System.Windows.Forms.MaskedTextBox maskedTextBox4;
        public System.Windows.Forms.MaskedTextBox maskedTextBox5;
        public System.Windows.Forms.MaskedTextBox maskedTextBox6;
        public System.Windows.Forms.MaskedTextBox maskedTextBox7;
        public System.Windows.Forms.MaskedTextBox maskedTextBox8;
        public System.Windows.Forms.TextBox matkb;
        public System.Windows.Forms.TextBox wepdb;
        public System.Windows.Forms.TextBox chrgb;
        public System.Windows.Forms.TextBox mdefb;
        public System.Windows.Forms.TextBox armb;
        public System.Windows.Forms.TextBox moraleb;
        public System.Windows.Forms.TextBox matk_r;
        public System.Windows.Forms.TextBox wepd_r;
        public System.Windows.Forms.TextBox chrg_r;
        public System.Windows.Forms.TextBox mdef_r;
        public System.Windows.Forms.TextBox armour_r;
        public System.Windows.Forms.TextBox morale_r;
    }
}

