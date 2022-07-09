namespace MagicDates
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_magic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Date";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Location = new System.Drawing.Point(308, 13);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(29, 13);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "Day:";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(414, 13);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(40, 13);
            this.lbl_month.TabIndex = 3;
            this.lbl_month.Text = "Month:";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(528, 13);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(31, 13);
            this.lbl_sum.TabIndex = 4;
            this.lbl_sum.Text = "Sum:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(527, 42);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(32, 13);
            this.lbl_Year.TabIndex = 5;
            this.lbl_Year.Text = "Year:";
            // 
            // lbl_magic
            // 
            this.lbl_magic.AutoSize = true;
            this.lbl_magic.Location = new System.Drawing.Point(308, 72);
            this.lbl_magic.Name = "lbl_magic";
            this.lbl_magic.Size = new System.Drawing.Size(113, 13);
            this.lbl_magic.TabIndex = 6;
            this.lbl_magic.Text = "Nothing Special About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_magic);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Magic Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_magic;
    }
}

