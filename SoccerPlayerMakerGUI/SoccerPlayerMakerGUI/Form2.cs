using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerPlayerMakerGUI
{
    public partial class Form2 : Form
    {
        BindingSource bs = new BindingSource();
        public Form2()
        {
            InitializeComponent();

            bs.DataSource = FootballerList.footballers;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "name";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {


            }
        }

        private void Btn_Az_Click(object sender, EventArgs e)
        {
            FootballerList.footballers.Sort();
            bs.ResetBindings(false);
        }

        private void Btn_Za_Click(object sender, EventArgs e)
        {
            FootballerList.footballers.Sort();
            FootballerList.footballers.Reverse();
            bs.ResetBindings(false);
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            FootballerList.footballers.Remove((Footballer)listBox1.SelectedItem);
            bs.ResetBindings(false);
        }
    }
}
