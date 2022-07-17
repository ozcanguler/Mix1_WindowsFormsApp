using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingsource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_CreateCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new Car(txtBox_Make.Text, txtBox_Model.Text, decimal.Parse(txtBox_Price.Text));
                myStore.carList.Add(c);
                carInventoryBindingsource.ResetBindings(false);
                txtBox_Make.Text = "";
                txtBox_Model.Text = "";
                txtBox_Price.Text = "";
            }
          
            //MessageBox.Show(c.ToString());

         
            catch
            {
                MessageBox.Show("Enter the number please!");
                
            }
          
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingsource.DataSource = myStore.carList;

            cartBindingSource.DataSource = myStore.shoppingList;


            lstBox_CarInv.DataSource = carInventoryBindingsource;
            lstBox_CarInv.DisplayMember = ToString();

            lstBox_ShopCart.DataSource = cartBindingSource;
            lstBox_ShopCart.DisplayMember = ToString();

        }

        private void Btn_AddCart_Click(object sender, EventArgs e)
        {
            //get the selected item from inventory
            Car selected = (Car)lstBox_CarInv.SelectedItem;
            //add that item to the cart
            myStore.shoppingList.Add(selected);
            //update the listbox control
            cartBindingSource.ResetBindings(false);
        }

        private void Btn_Checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.checkout();
            lbl_Total.Text = "$"+total.ToString();

            cartBindingSource.ResetBindings(false);
        }

    }
}
