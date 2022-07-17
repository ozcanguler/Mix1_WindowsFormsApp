namespace CarShopGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CreateCar = new System.Windows.Forms.Button();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_Model = new System.Windows.Forms.TextBox();
            this.txtBox_Make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBox_CarInv = new System.Windows.Forms.ListBox();
            this.btn_AddCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstBox_ShopCart = new System.Windows.Forms.ListBox();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CreateCar);
            this.groupBox1.Controls.Add(this.txtBox_Price);
            this.groupBox1.Controls.Add(this.txtBox_Model);
            this.groupBox1.Controls.Add(this.txtBox_Make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            // 
            // btn_CreateCar
            // 
            this.btn_CreateCar.Location = new System.Drawing.Point(66, 188);
            this.btn_CreateCar.Name = "btn_CreateCar";
            this.btn_CreateCar.Size = new System.Drawing.Size(76, 34);
            this.btn_CreateCar.TabIndex = 1;
            this.btn_CreateCar.Text = "Create a Car";
            this.btn_CreateCar.UseVisualStyleBackColor = true;
            this.btn_CreateCar.Click += new System.EventHandler(this.Btn_CreateCar_Click);
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(75, 128);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Price.TabIndex = 3;
            // 
            // txtBox_Model
            // 
            this.txtBox_Model.Location = new System.Drawing.Point(75, 82);
            this.txtBox_Model.Name = "txtBox_Model";
            this.txtBox_Model.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Model.TabIndex = 2;
            // 
            // txtBox_Make
            // 
            this.txtBox_Make.Location = new System.Drawing.Point(75, 36);
            this.txtBox_Make.Name = "txtBox_Make";
            this.txtBox_Make.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Make.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBox_CarInv);
            this.groupBox2.Location = new System.Drawing.Point(258, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory:";
            // 
            // lstBox_CarInv
            // 
            this.lstBox_CarInv.FormattingEnabled = true;
            this.lstBox_CarInv.Location = new System.Drawing.Point(6, 19);
            this.lstBox_CarInv.Name = "lstBox_CarInv";
            this.lstBox_CarInv.Size = new System.Drawing.Size(216, 225);
            this.lstBox_CarInv.TabIndex = 0;
            // 
            // btn_AddCart
            // 
            this.btn_AddCart.Location = new System.Drawing.Point(517, 132);
            this.btn_AddCart.Name = "btn_AddCart";
            this.btn_AddCart.Size = new System.Drawing.Size(86, 36);
            this.btn_AddCart.TabIndex = 2;
            this.btn_AddCart.Text = "Add to Cart ->";
            this.btn_AddCart.UseVisualStyleBackColor = true;
            this.btn_AddCart.Click += new System.EventHandler(this.Btn_AddCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstBox_ShopCart);
            this.groupBox3.Location = new System.Drawing.Point(638, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 254);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart:";
            // 
            // lstBox_ShopCart
            // 
            this.lstBox_ShopCart.FormattingEnabled = true;
            this.lstBox_ShopCart.Location = new System.Drawing.Point(6, 19);
            this.lstBox_ShopCart.Name = "lstBox_ShopCart";
            this.lstBox_ShopCart.Size = new System.Drawing.Size(207, 225);
            this.lstBox_ShopCart.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Location = new System.Drawing.Point(677, 294);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_Checkout.TabIndex = 4;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.Btn_Checkout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(717, 358);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(34, 13);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_AddCart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CreateCar;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.TextBox txtBox_Model;
        private System.Windows.Forms.TextBox txtBox_Make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBox_CarInv;
        private System.Windows.Forms.Button btn_AddCart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstBox_ShopCart;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Total;
    }
}

