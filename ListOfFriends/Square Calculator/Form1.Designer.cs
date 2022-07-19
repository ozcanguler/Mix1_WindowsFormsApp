namespace Square_Calculator
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_Stop = new System.Windows.Forms.Label();
            this.txtBox_Start = new System.Windows.Forms.TextBox();
            this.txtBox_Stop = new System.Windows.Forms.TextBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.txtBox_Count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(408, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 225);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Cal
            // 
            this.btn_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cal.Location = new System.Drawing.Point(111, 158);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(104, 34);
            this.btn_Cal.TabIndex = 1;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.Btn_Cal_Click);
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start.Location = new System.Drawing.Point(36, 60);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(68, 24);
            this.lbl_Start.TabIndex = 2;
            this.lbl_Start.Text = "Start At";
            // 
            // lbl_Stop
            // 
            this.lbl_Stop.AutoSize = true;
            this.lbl_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stop.Location = new System.Drawing.Point(36, 99);
            this.lbl_Stop.Name = "lbl_Stop";
            this.lbl_Stop.Size = new System.Drawing.Size(70, 24);
            this.lbl_Stop.TabIndex = 3;
            this.lbl_Stop.Text = "Stop At";
            // 
            // txtBox_Start
            // 
            this.txtBox_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Start.Location = new System.Drawing.Point(111, 57);
            this.txtBox_Start.Name = "txtBox_Start";
            this.txtBox_Start.Size = new System.Drawing.Size(176, 29);
            this.txtBox_Start.TabIndex = 4;
            // 
            // txtBox_Stop
            // 
            this.txtBox_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Stop.Location = new System.Drawing.Point(111, 96);
            this.txtBox_Stop.Name = "txtBox_Stop";
            this.txtBox_Stop.Size = new System.Drawing.Size(176, 29);
            this.txtBox_Stop.TabIndex = 5;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(326, 57);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(60, 24);
            this.lbl_Count.TabIndex = 6;
            this.lbl_Count.Text = "Count";
            // 
            // txtBox_Count
            // 
            this.txtBox_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Count.Location = new System.Drawing.Point(330, 96);
            this.txtBox_Count.Name = "txtBox_Count";
            this.txtBox_Count.Size = new System.Drawing.Size(56, 29);
            this.txtBox_Count.TabIndex = 7;
            this.txtBox_Count.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_Count);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.txtBox_Stop);
            this.Controls.Add(this.txtBox_Start);
            this.Controls.Add(this.lbl_Stop);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_Stop;
        private System.Windows.Forms.TextBox txtBox_Start;
        private System.Windows.Forms.TextBox txtBox_Stop;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.TextBox txtBox_Count;
    }
}

