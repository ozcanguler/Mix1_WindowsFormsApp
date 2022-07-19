namespace Loan_Calculator
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
            this.lbl_StartBal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_StartBal = new System.Windows.Forms.TextBox();
            this.txtBox_Months = new System.Windows.Forms.TextBox();
            this.txtBox_inrate = new System.Windows.Forms.TextBox();
            this.txtBox_EndBal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 160);
            this.listBox1.TabIndex = 0;
            // 
            // lbl_StartBal
            // 
            this.lbl_StartBal.AutoSize = true;
            this.lbl_StartBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartBal.Location = new System.Drawing.Point(36, 28);
            this.lbl_StartBal.Name = "lbl_StartBal";
            this.lbl_StartBal.Size = new System.Drawing.Size(145, 24);
            this.lbl_StartBal.TabIndex = 1;
            this.lbl_StartBal.Text = "Starting Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interest Rate";
            // 
            // txtBox_StartBal
            // 
            this.txtBox_StartBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_StartBal.Location = new System.Drawing.Point(209, 28);
            this.txtBox_StartBal.Name = "txtBox_StartBal";
            this.txtBox_StartBal.Size = new System.Drawing.Size(140, 29);
            this.txtBox_StartBal.TabIndex = 4;
            // 
            // txtBox_Months
            // 
            this.txtBox_Months.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Months.Location = new System.Drawing.Point(209, 73);
            this.txtBox_Months.Name = "txtBox_Months";
            this.txtBox_Months.Size = new System.Drawing.Size(140, 29);
            this.txtBox_Months.TabIndex = 5;
            // 
            // txtBox_inrate
            // 
            this.txtBox_inrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_inrate.Location = new System.Drawing.Point(209, 121);
            this.txtBox_inrate.Name = "txtBox_inrate";
            this.txtBox_inrate.Size = new System.Drawing.Size(140, 29);
            this.txtBox_inrate.TabIndex = 6;
            // 
            // txtBox_EndBal
            // 
            this.txtBox_EndBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EndBal.Location = new System.Drawing.Point(209, 348);
            this.txtBox_EndBal.Name = "txtBox_EndBal";
            this.txtBox_EndBal.ReadOnly = true;
            this.txtBox_EndBal.Size = new System.Drawing.Size(140, 29);
            this.txtBox_EndBal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ending Balance";
            // 
            // btn_Cal
            // 
            this.btn_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cal.Location = new System.Drawing.Point(94, 399);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(86, 38);
            this.btn_Cal.TabIndex = 9;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.Btn_Cal_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(209, 399);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 38);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(324, 400);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 38);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_EndBal);
            this.Controls.Add(this.txtBox_inrate);
            this.Controls.Add(this.txtBox_Months);
            this.Controls.Add(this.txtBox_StartBal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_StartBal);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_StartBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_StartBal;
        private System.Windows.Forms.TextBox txtBox_Months;
        private System.Windows.Forms.TextBox txtBox_inrate;
        private System.Windows.Forms.TextBox txtBox_EndBal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}

