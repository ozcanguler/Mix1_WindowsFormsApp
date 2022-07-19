namespace ListOfFriends
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
            this.lstBox_name = new System.Windows.Forms.ListBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_sumnames = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_resort = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_name
            // 
            this.lstBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_name.FormattingEnabled = true;
            this.lstBox_name.ItemHeight = 24;
            this.lstBox_name.Location = new System.Drawing.Point(29, 43);
            this.lstBox_name.Name = "lstBox_name";
            this.lstBox_name.Size = new System.Drawing.Size(211, 268);
            this.lstBox_name.TabIndex = 0;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(337, 43);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(208, 29);
            this.txtbox_name.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(357, 103);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // lbl_sumnames
            // 
            this.lbl_sumnames.AutoSize = true;
            this.lbl_sumnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumnames.Location = new System.Drawing.Point(498, 107);
            this.lbl_sumnames.Name = "lbl_sumnames";
            this.lbl_sumnames.Size = new System.Drawing.Size(70, 25);
            this.lbl_sumnames.TabIndex = 3;
            this.lbl_sumnames.Text = "label1";
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(357, 269);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(86, 37);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "A->Z";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.Btn_sort_Click);
            // 
            // btn_resort
            // 
            this.btn_resort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resort.Location = new System.Drawing.Point(475, 268);
            this.btn_resort.Name = "btn_resort";
            this.btn_resort.Size = new System.Drawing.Size(86, 37);
            this.btn_resort.TabIndex = 5;
            this.btn_resort.Text = "Z->A";
            this.btn_resort.UseVisualStyleBackColor = true;
            this.btn_resort.Click += new System.EventHandler(this.Btn_resort_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(605, 268);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 37);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_resort);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.lbl_sumnames);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lstBox_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_name;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_sumnames;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_resort;
        private System.Windows.Forms.Button btn_clear;
    }
}

