using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfFriends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = namelist;
        }

        List<string> namelist = new List<string>();
        BindingSource bs = new BindingSource();
        private void Btn_add_Click(object sender, EventArgs e)
        {

          

            namelist.Add(txtbox_name.Text);
            lstBox_name.DataSource = bs;
            if (namelist.Count < 2)
            {
                lbl_sumnames.Text = namelist.Count + " friend";            
            }
            else
            {
                lbl_sumnames.Text = namelist.Count + " friends";
            }
            bs.ResetBindings(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btn_sort_Click(object sender, EventArgs e)
        {
            namelist.Sort();
            bs.ResetBindings(false);

            
            
        }

        private void Btn_resort_Click(object sender, EventArgs e)
        {
            namelist.Sort();
            namelist.Reverse();
            bs.ResetBindings(false);

        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            namelist.Clear();
            lstBox_name.DataSource = bs;
            lbl_sumnames.Text = namelist.Count + " friend";
            bs.ResetBindings(false);
            MessageBox.Show(namelist.Count.ToString());
        }
    }
}