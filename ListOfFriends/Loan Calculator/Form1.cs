using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        //decimal loan_amount = 0.00m;
        //int number_of_months = 0;
        //decimal interest_rate = 0.005m;
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = cal;
        }
        BindingSource bs = new BindingSource();


        List<string> cal = new List<string>();
        double sum;
        double month;
        int i = 0;
        private void Btn_Cal_Click(object sender, EventArgs e)
        {
            //Convert.ToDouble(txtBox_StartBal.Text)

            //1st way
            //try
            //{
            //    loan_amount = decimal.Parse(txtBox_StartBal.Text);
            //    number_of_months = int.Parse(txtBox_Months.Text);
            //    interest_rate = decimal.Parse(txtBox_inrate.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter a number here");

            //}

            //2nd way

           //if( decimal.TryParse(txtBox_StartBal.Text, out loan_amount))
           // {
           //     if (int.TryParse(txtBox_Months.Text, out number_of_months))
           //     {
           //         if(decimal.TryParse(txtBox_inrate.Text, out interest_rate))
           //         {
           //             int counter = 0;
           //             while (counter < number_of_months)
                        
           //             {
           //                 loan_amount = loan_amount + loan_amount * interest_rate;
           //                 listBox1.Items.Add("At month " + counter + "the loan is " + loan_amount.ToString("c")); // c harfi currency gelir $ işareti yapar.
           //                 counter++;
           //             }
           //             txtBox_EndBal.Text = loan_amount.ToString("c");

           //         }
           //     }
           // }




            try
            {
                month = Convert.ToDouble(txtBox_Months.Text);
                sum = Convert.ToDouble(txtBox_StartBal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



            while (i < month)
            {
                try
                {
                    sum = sum + (sum * Convert.ToDouble(txtBox_inrate.Text));
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);

                }


                sum = Math.Round(sum, 2);
                i++;
                cal.Add($"Month:{i} Balance= ${sum}");

                listBox1.DataSource = bs;

            }

            txtBox_EndBal.Text = Math.Round(sum, 3).ToString();
            bs.ResetBindings(false);
            if (i == month)
            {
                cal.Clear();
            }
            i = 0;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {

            //txtBox_EndBal.Text = "";
            //txtBox_inrate.Text = "";
            //txtBox_Months.Text = "";
            //listBox1.Items.Clear();


            cal.Clear();
            txtBox_EndBal.Clear();
            txtBox_Months.Clear();
            txtBox_StartBal.Clear();
            txtBox_inrate.Clear();
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            i = 0;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
