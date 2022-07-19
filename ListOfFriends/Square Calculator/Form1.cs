using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Calculator
{
    public partial class Form1 : Form
    {
        int start,stop,countby=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Cal_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           if(int.TryParse(txtBox_Start.Text,out start))
           {
                if(int.TryParse(txtBox_Stop.Text,out stop))
                {
                    if(int.TryParse(txtBox_Count.Text,out countby))
                    {
                        if (start > stop)
                        {
                            int temp;
                            temp = start;
                            start=stop;
                            stop = temp;
                        }

                        for (int i = start; i < stop; i += countby)
                            {
                                start = i * i;
                                listBox1.Items.Add(i + " squared is= " + start);

                            }
                       
                    }
                  
                }

           }
        }
    }
}
