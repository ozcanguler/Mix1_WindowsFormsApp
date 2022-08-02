namespace SoccerPlayerMakerGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chck_Sprint = new System.Windows.Forms.CheckBox();
            this.chck_Shooting = new System.Windows.Forms.CheckBox();
            this.chck_Steal = new System.Windows.Forms.CheckBox();
            this.chck_FreeKick = new System.Windows.Forms.CheckBox();
            this.chck_Penalty = new System.Windows.Forms.CheckBox();
            this.chck_Deception = new System.Windows.Forms.CheckBox();
            this.chck_Resistant = new System.Windows.Forms.CheckBox();
            this.chck_Feint = new System.Windows.Forms.CheckBox();
            this.lst_Countries = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_For = new System.Windows.Forms.RadioButton();
            this.rad_Mid = new System.Windows.Forms.RadioButton();
            this.rad_Def = new System.Windows.Forms.RadioButton();
            this.rad_Goalkeep = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrool_Age = new System.Windows.Forms.HScrollBar();
            this.scrool_Int = new System.Windows.Forms.HScrollBar();
            this.scrool_Speed = new System.Windows.Forms.HScrollBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_tfdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.date_tsdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.num_yearExp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_hapStatus = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pic_uniNum = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_yearExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_uniNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player\'s Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(101, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chck_Sprint);
            this.groupBox1.Controls.Add(this.chck_Shooting);
            this.groupBox1.Controls.Add(this.chck_Steal);
            this.groupBox1.Controls.Add(this.chck_FreeKick);
            this.groupBox1.Controls.Add(this.chck_Penalty);
            this.groupBox1.Controls.Add(this.chck_Deception);
            this.groupBox1.Controls.Add(this.chck_Resistant);
            this.groupBox1.Controls.Add(this.chck_Feint);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilities";
            // 
            // chck_Sprint
            // 
            this.chck_Sprint.AutoSize = true;
            this.chck_Sprint.Location = new System.Drawing.Point(108, 88);
            this.chck_Sprint.Name = "chck_Sprint";
            this.chck_Sprint.Size = new System.Drawing.Size(53, 17);
            this.chck_Sprint.TabIndex = 7;
            this.chck_Sprint.Text = "Sprint";
            this.chck_Sprint.UseVisualStyleBackColor = true;
            // 
            // chck_Shooting
            // 
            this.chck_Shooting.AutoSize = true;
            this.chck_Shooting.Location = new System.Drawing.Point(108, 65);
            this.chck_Shooting.Name = "chck_Shooting";
            this.chck_Shooting.Size = new System.Drawing.Size(68, 17);
            this.chck_Shooting.TabIndex = 6;
            this.chck_Shooting.Text = "Shooting";
            this.chck_Shooting.UseVisualStyleBackColor = true;
            // 
            // chck_Steal
            // 
            this.chck_Steal.AutoSize = true;
            this.chck_Steal.Location = new System.Drawing.Point(108, 42);
            this.chck_Steal.Name = "chck_Steal";
            this.chck_Steal.Size = new System.Drawing.Size(64, 17);
            this.chck_Steal.TabIndex = 5;
            this.chck_Steal.Text = "Stealing";
            this.chck_Steal.UseVisualStyleBackColor = true;
            // 
            // chck_FreeKick
            // 
            this.chck_FreeKick.AutoSize = true;
            this.chck_FreeKick.Location = new System.Drawing.Point(108, 19);
            this.chck_FreeKick.Name = "chck_FreeKick";
            this.chck_FreeKick.Size = new System.Drawing.Size(71, 17);
            this.chck_FreeKick.TabIndex = 4;
            this.chck_FreeKick.Text = "Free Kick";
            this.chck_FreeKick.UseVisualStyleBackColor = true;
            // 
            // chck_Penalty
            // 
            this.chck_Penalty.AutoSize = true;
            this.chck_Penalty.Location = new System.Drawing.Point(6, 88);
            this.chck_Penalty.Name = "chck_Penalty";
            this.chck_Penalty.Size = new System.Drawing.Size(61, 17);
            this.chck_Penalty.TabIndex = 3;
            this.chck_Penalty.Text = "Penalty";
            this.chck_Penalty.UseVisualStyleBackColor = true;
            // 
            // chck_Deception
            // 
            this.chck_Deception.AutoSize = true;
            this.chck_Deception.Location = new System.Drawing.Point(6, 65);
            this.chck_Deception.Name = "chck_Deception";
            this.chck_Deception.Size = new System.Drawing.Size(75, 17);
            this.chck_Deception.TabIndex = 2;
            this.chck_Deception.Text = "Deception";
            this.chck_Deception.UseVisualStyleBackColor = true;
            // 
            // chck_Resistant
            // 
            this.chck_Resistant.AutoSize = true;
            this.chck_Resistant.Location = new System.Drawing.Point(6, 42);
            this.chck_Resistant.Name = "chck_Resistant";
            this.chck_Resistant.Size = new System.Drawing.Size(70, 17);
            this.chck_Resistant.TabIndex = 1;
            this.chck_Resistant.Text = "Resistant";
            this.chck_Resistant.UseVisualStyleBackColor = true;
            // 
            // chck_Feint
            // 
            this.chck_Feint.AutoSize = true;
            this.chck_Feint.Location = new System.Drawing.Point(6, 19);
            this.chck_Feint.Name = "chck_Feint";
            this.chck_Feint.Size = new System.Drawing.Size(49, 17);
            this.chck_Feint.TabIndex = 0;
            this.chck_Feint.Text = "Feint";
            this.chck_Feint.UseVisualStyleBackColor = true;
            // 
            // lst_Countries
            // 
            this.lst_Countries.FormattingEnabled = true;
            this.lst_Countries.Items.AddRange(new object[] {
            "Argentina",
            "Brazil",
            "Colombia",
            "France",
            "Germany",
            "Italy",
            "Netherlands",
            "Portugal",
            "Spain",
            "Turkey"});
            this.lst_Countries.Location = new System.Drawing.Point(15, 194);
            this.lst_Countries.Name = "lst_Countries";
            this.lst_Countries.Size = new System.Drawing.Size(120, 121);
            this.lst_Countries.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_For);
            this.groupBox2.Controls.Add(this.rad_Mid);
            this.groupBox2.Controls.Add(this.rad_Def);
            this.groupBox2.Controls.Add(this.rad_Goalkeep);
            this.groupBox2.Location = new System.Drawing.Point(160, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // rad_For
            // 
            this.rad_For.AutoSize = true;
            this.rad_For.Location = new System.Drawing.Point(6, 88);
            this.rad_For.Name = "rad_For";
            this.rad_For.Size = new System.Drawing.Size(63, 17);
            this.rad_For.TabIndex = 3;
            this.rad_For.TabStop = true;
            this.rad_For.Text = "Forward";
            this.rad_For.UseVisualStyleBackColor = true;
            // 
            // rad_Mid
            // 
            this.rad_Mid.AutoSize = true;
            this.rad_Mid.Location = new System.Drawing.Point(6, 65);
            this.rad_Mid.Name = "rad_Mid";
            this.rad_Mid.Size = new System.Drawing.Size(78, 17);
            this.rad_Mid.TabIndex = 2;
            this.rad_Mid.TabStop = true;
            this.rad_Mid.Text = "MidFielders";
            this.rad_Mid.UseVisualStyleBackColor = true;
            // 
            // rad_Def
            // 
            this.rad_Def.AutoSize = true;
            this.rad_Def.Location = new System.Drawing.Point(6, 42);
            this.rad_Def.Name = "rad_Def";
            this.rad_Def.Size = new System.Drawing.Size(69, 17);
            this.rad_Def.TabIndex = 1;
            this.rad_Def.TabStop = true;
            this.rad_Def.Text = "Defender";
            this.rad_Def.UseVisualStyleBackColor = true;
            // 
            // rad_Goalkeep
            // 
            this.rad_Goalkeep.AutoSize = true;
            this.rad_Goalkeep.Location = new System.Drawing.Point(6, 19);
            this.rad_Goalkeep.Name = "rad_Goalkeep";
            this.rad_Goalkeep.Size = new System.Drawing.Size(81, 17);
            this.rad_Goalkeep.TabIndex = 0;
            this.rad_Goalkeep.TabStop = true;
            this.rad_Goalkeep.Text = "GoalKeeper";
            this.rad_Goalkeep.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Age);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_Int);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbl_Speed);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.scrool_Age);
            this.groupBox3.Controls.Add(this.scrool_Int);
            this.groupBox3.Controls.Add(this.scrool_Speed);
            this.groupBox3.Location = new System.Drawing.Point(15, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 154);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed-Intelligent-Age";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(68, 108);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(13, 13);
            this.lbl_Age.TabIndex = 8;
            this.lbl_Age.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Age:";
            // 
            // lbl_Int
            // 
            this.lbl_Int.AutoSize = true;
            this.lbl_Int.Location = new System.Drawing.Point(68, 63);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(13, 13);
            this.lbl_Int.TabIndex = 6;
            this.lbl_Int.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Intelligent:";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Location = new System.Drawing.Point(68, 16);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(13, 13);
            this.lbl_Speed.TabIndex = 4;
            this.lbl_Speed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed:";
            // 
            // scrool_Age
            // 
            this.scrool_Age.Location = new System.Drawing.Point(6, 128);
            this.scrool_Age.Maximum = 109;
            this.scrool_Age.Name = "scrool_Age";
            this.scrool_Age.Size = new System.Drawing.Size(188, 18);
            this.scrool_Age.TabIndex = 2;
            this.scrool_Age.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrool_Age_Scroll);
            // 
            // scrool_Int
            // 
            this.scrool_Int.Location = new System.Drawing.Point(3, 86);
            this.scrool_Int.Maximum = 109;
            this.scrool_Int.Name = "scrool_Int";
            this.scrool_Int.Size = new System.Drawing.Size(188, 18);
            this.scrool_Int.TabIndex = 1;
            this.scrool_Int.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrool_Int_Scroll);
            // 
            // scrool_Speed
            // 
            this.scrool_Speed.Location = new System.Drawing.Point(6, 38);
            this.scrool_Speed.Maximum = 109;
            this.scrool_Speed.Name = "scrool_Speed";
            this.scrool_Speed.Size = new System.Drawing.Size(188, 18);
            this.scrool_Speed.TabIndex = 0;
            this.scrool_Speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrool_Speed_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.date_tfdate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.date_tsdate);
            this.groupBox4.Location = new System.Drawing.Point(446, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 119);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Transfer Finish Date";
            // 
            // date_tfdate
            // 
            this.date_tfdate.Location = new System.Drawing.Point(6, 83);
            this.date_tfdate.Name = "date_tfdate";
            this.date_tfdate.Size = new System.Drawing.Size(200, 20);
            this.date_tfdate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Transfer Start Date";
            // 
            // date_tsdate
            // 
            this.date_tsdate.Location = new System.Drawing.Point(6, 37);
            this.date_tsdate.Name = "date_tsdate";
            this.date_tsdate.Size = new System.Drawing.Size(200, 20);
            this.date_tsdate.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Years of Experience";
            // 
            // num_yearExp
            // 
            this.num_yearExp.Location = new System.Drawing.Point(571, 188);
            this.num_yearExp.Name = "num_yearExp";
            this.num_yearExp.Size = new System.Drawing.Size(120, 20);
            this.num_yearExp.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Favourite Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Location = new System.Drawing.Point(556, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 63);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Happiness Status";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(571, 334);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(146, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // lbl_hapStatus
            // 
            this.lbl_hapStatus.AutoSize = true;
            this.lbl_hapStatus.Location = new System.Drawing.Point(474, 372);
            this.lbl_hapStatus.Name = "lbl_hapStatus";
            this.lbl_hapStatus.Size = new System.Drawing.Size(13, 13);
            this.lbl_hapStatus.TabIndex = 14;
            this.lbl_hapStatus.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pic_uniNum);
            this.groupBox5.Location = new System.Drawing.Point(444, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uniform Number";
            // 
            // pic_uniNum
            // 
            this.pic_uniNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_uniNum.Location = new System.Drawing.Point(6, 19);
            this.pic_uniNum.Name = "pic_uniNum";
            this.pic_uniNum.Size = new System.Drawing.Size(188, 75);
            this.pic_uniNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_uniNum.TabIndex = 0;
            this.pic_uniNum.TabStop = false;
            this.pic_uniNum.Click += new System.EventHandler(this.Pic_uniNum_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(689, 457);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(689, 493);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 17;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lbl_hapStatus);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_yearExp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Countries);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SoccerPlayerCreator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_yearExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_uniNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chck_Sprint;
        private System.Windows.Forms.CheckBox chck_Shooting;
        private System.Windows.Forms.CheckBox chck_Steal;
        private System.Windows.Forms.CheckBox chck_FreeKick;
        private System.Windows.Forms.CheckBox chck_Penalty;
        private System.Windows.Forms.CheckBox chck_Deception;
        private System.Windows.Forms.CheckBox chck_Resistant;
        private System.Windows.Forms.CheckBox chck_Feint;
        private System.Windows.Forms.ListBox lst_Countries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_For;
        private System.Windows.Forms.RadioButton rad_Mid;
        private System.Windows.Forms.RadioButton rad_Def;
        private System.Windows.Forms.RadioButton rad_Goalkeep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar scrool_Age;
        private System.Windows.Forms.HScrollBar scrool_Int;
        private System.Windows.Forms.HScrollBar scrool_Speed;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Int;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_tfdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_tsdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_yearExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_hapStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pic_uniNum;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Create;
    }
}

