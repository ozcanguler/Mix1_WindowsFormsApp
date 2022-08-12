using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListManagerApp
{
    public partial class Form1 : Form
    {
        string filePath = @"C:\Users\Garavel\Desktop\Sluiter\ListManagerApp\ListManagerApp\listData.txt";
        //List<string> names = new List<string>();
        static List<String> names = new List<string>();



        internal void receiveData(string newName)
        {
            names.Add(newName);
            //listBox1.DataSource = namesBindingSource;
            //namesBindingSource.ResetBindings(false);           
            //MessageBox.Show("Items count:" + names.Count);
            File.WriteAllText(filePath, "");
            for (int z = 0; z < names.Count; z++)
            {
                MessageBox.Show(names[z]);
                File.WriteAllLines(filePath, names);
            }
        }

        BindingSource namesBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            names = File.ReadAllLines(filePath).ToList();
            //add the names to the listbox
            namesBindingSource.DataSource = names;
            listBox1.DataSource = namesBindingSource;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            namesBindingSource.ResetBindings(false);
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (i >= 0)
            {
                DialogResult result = MessageBox.Show("Would you like to delete " + names[i] + "?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    names.RemoveAt(i);
                    namesBindingSource.ResetBindings(false);
                    names.Clear();
                    foreach (var item in listBox1.Items)
                    {
                        names.Add(item.ToString());
                    }

                    File.WriteAllText(filePath, "");
                    for (int z = 0; z < names.Count; z++)
                    {
                        MessageBox.Show(names[z]);
                        File.WriteAllLines(filePath, names);
                    }


                }

            }


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                names.Sort();
                namesBindingSource.ResetBindings(false);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                names.Sort();
                names.Reverse();
                namesBindingSource.ResetBindings(false);
            }
        }
    }
}
