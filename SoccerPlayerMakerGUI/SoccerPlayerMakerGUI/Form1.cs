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
    public partial class Form1 : Form
    {
        string picture_uniformNumber = "";

        //FootballerList myFootballerList = new FootballerList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Scrool_Speed_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Speed.Text = scrool_Speed.Value.ToString();
        }
        private void Scrool_Int_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Int.Text = scrool_Int.Value.ToString();
        }
        private void Scrool_Age_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Age.Text = scrool_Age.Value.ToString();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorPicker.Color;
            }

        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_hapStatus.Text = trackBar1.Value.ToString();
        }

        private void Pic_uniNum_Click(object sender, EventArgs e)
        {
            OpenFileDialog uniformNumber = new OpenFileDialog();

            if (uniformNumber.ShowDialog() == DialogResult.OK)
            {
                pic_uniNum.Image = new Bitmap(uniformNumber.FileName);
            }

            picture_uniformNumber = uniformNumber.FileName;
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.StartPosition = FormStartPosition.Manual;
            NewForm.Location = this.Location;

            NewForm.Show();
            this.Dispose(false);
        }
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            string footballerName = txt_Name.Text;
            bool[] abilities = { false, false, false, false, false, false, false, false };
            abilities[0] = chck_Feint.Checked;
            abilities[1] = chck_Resistant.Checked;
            abilities[2] = chck_Deception.Checked;
            abilities[3] = chck_Penalty.Checked;
            abilities[4] = chck_FreeKick.Checked;
            abilities[5] = chck_Steal.Checked;
            abilities[6] = chck_Shooting.Checked;
            abilities[7] = chck_Sprint.Checked;

            List<String> countries = new List<String>();


            countries.Add(lst_Countries.SelectedItem.ToString());

            string position = "";

            if (rad_Goalkeep.Checked)
            {
                position = rad_Goalkeep.Text;
            }
            if (rad_Def.Checked)
            {
                position = rad_Def.Text;
            }
            if (rad_Mid.Checked)
            {
                position = rad_Mid.Text;
            }
            if (rad_For.Checked)
            {
                position = rad_For.Text;
            }

            int speed = scrool_Speed.Value;
            int intelligent = scrool_Int.Value;
            int age = scrool_Age.Value;
            decimal yearExperience = num_yearExp.Value;
            DateTime tstartDate = date_tsdate.Value;
            DateTime tfinishDate = date_tfdate.Value;




            string status_message = "Your new player is " + txt_Name.Text + ". \nYou have selected the following abilities:";
            if (abilities[0]) status_message += "Feint, ";
            if (abilities[1]) status_message += "Resistant, ";
            if (abilities[2]) status_message += "Deception, ";
            if (abilities[3]) status_message += "Penalty, ";
            if (abilities[4]) status_message += "FreeKick, ";
            if (abilities[5]) status_message += "Steal, ";
            if (abilities[6]) status_message += "Shooting, ";
            if (abilities[7]) status_message += "Sprint, ";

            if (speed + intelligent + age > 100)
            {
                MessageBox.Show("You cannot have more than 100 total points for speed, intelligent and age.");
                lbl_Speed.Text = "0";
                lbl_Int.Text = "0";
                lbl_Age.Text = "0";
                scrool_Age.Value = scrool_Age.Minimum;
                scrool_Int.Value = scrool_Int.Minimum;
                scrool_Speed.Value = scrool_Speed.Minimum;
            }
            else
            {
                status_message += "\nCountry of the football player: " + countries[0];
                status_message += "\nPosition: " + position;
                status_message += "\nSpeed: " + speed + " Intelligent: " + intelligent + " Age: " + age;
                status_message += "\nTransfer Start Date: " + tstartDate.Month + "/" + tstartDate.Day + "/" + tstartDate.Year + "\nTransfer Finish Date: " + tfinishDate.Month + "/" + tfinishDate.Day + "/" + tfinishDate.Year;
                status_message += "\nYear Experience: " + yearExperience;
                status_message += "\nThe favourite color: " + pictureBox1.BackColor.ToString();

                int hapStatus;
                hapStatus = int.Parse(lbl_hapStatus.Text);
                if (hapStatus > 0)
                {
                    status_message += "\nHappiness Status: Happy" + " Happiness Value: " + hapStatus;
                }
                else if (hapStatus < 0)
                {
                    status_message += "\nHappiness Status: Unhappy" + " Happiness Value: " + hapStatus;
                }
                else
                {
                    status_message += "\nHappiness Status: Insensitive" + " Happiness Value: " + hapStatus;
                }
                status_message += "\nThe uniformNumber is: " + picture_uniformNumber;


                Footballer footballer = new Footballer(footballerName, abilities, countries, position, speed, intelligent, age, tstartDate, tfinishDate, yearExperience, pictureBox1.BackColor.ToString(), hapStatus, picture_uniformNumber);


                FootballerList.footballers.Add(footballer);
                //myFootballerList.footballers.Add(footballer);

                MessageBox.Show(status_message);
                //MessageBox.Show(myFootballerList.footballers.Count.ToString());

                Form2 f2 = new Form2();
                f2.Show();
            }


        }

      
    }
}
