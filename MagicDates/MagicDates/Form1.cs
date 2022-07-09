using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker1.Value;
            int day = chosenDate.Day;
            int month = chosenDate.Month;
            int year = chosenDate.Year;

            String yearString = year.ToString();
            String lastTwoDigits = yearString.Substring(2);
            int finalTwoValue = int.Parse(lastTwoDigits);

            if (day + month == finalTwoValue)
            {
                
                lbl_magic.Text = "Magic Number!";
                lbl_magic.ForeColor = Color.Red;
            }
            else
            {
                lbl_magic.Text = "This looks like an ordinary date.";
                lbl_magic.ForeColor = Color.Black;
            }
            lbl_day.Text = "Day: " + day;
            lbl_month.Text = "Month: " + month;
            lbl_Year.Text = "Year: " + year;
            lbl_sum.Text = "Sum: " + (day + month); 
        }
    }
}
