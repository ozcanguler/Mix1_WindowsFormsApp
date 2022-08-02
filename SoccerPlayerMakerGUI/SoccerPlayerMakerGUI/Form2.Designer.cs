namespace SoccerPlayerMakerGUI
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Az = new System.Windows.Forms.Button();
            this.btn_Za = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 390);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Az
            // 
            this.btn_Az.Location = new System.Drawing.Point(473, 24);
            this.btn_Az.Name = "btn_Az";
            this.btn_Az.Size = new System.Drawing.Size(75, 23);
            this.btn_Az.TabIndex = 2;
            this.btn_Az.Text = "A->Z";
            this.btn_Az.UseVisualStyleBackColor = true;
            this.btn_Az.Click += new System.EventHandler(this.Btn_Az_Click);
            // 
            // btn_Za
            // 
            this.btn_Za.Location = new System.Drawing.Point(580, 24);
            this.btn_Za.Name = "btn_Za";
            this.btn_Za.Size = new System.Drawing.Size(75, 23);
            this.btn_Za.TabIndex = 3;
            this.btn_Za.Text = "Z->A";
            this.btn_Za.UseVisualStyleBackColor = true;
            this.btn_Za.Click += new System.EventHandler(this.Btn_Za_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(687, 24);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_Za);
            this.Controls.Add(this.btn_Az);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Az;
        private System.Windows.Forms.Button btn_Za;
        private System.Windows.Forms.Button btn_del;
    }
}