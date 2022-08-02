using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerPlayerMakerGUI
{
    class Footballer:IComparable
    {
        public string name { get; set; }
        public bool[] specialAbilities { get; set; }
        public List<String> country { get; set; }
        public string position { get; set; }
        public int speed { get; set; }
        public int intelligent { get; set; }
        public int age { get; set; }

        public Footballer(string name,
            bool[] specialAbilities,
            List<string> country,
            string position,
            int speed,
            int intelligent,
            int age,
            DateTime transferStart,
            DateTime transferFinish,
            decimal yearsExperince,
            string favouriteColor,
            int happinessStatus,
            string uniformNumberPhoto)
        {
            this.name = name;
            this.specialAbilities = specialAbilities;
            this.country = country;
            this.position = position;
            this.speed = speed;
            this.intelligent = intelligent;
            this.age = age;
            this.transferStart = transferStart;
            this.transferFinish = transferFinish;
            this.yearsExperince = yearsExperince;
            this.favouriteColor = favouriteColor;
            this.happinessStatus = happinessStatus;
            this.uniformNumberPhoto = uniformNumberPhoto;
        }

        public DateTime transferStart { get; set; }
        public DateTime transferFinish { get; set; }
        public decimal yearsExperince { get; set; }
        public string favouriteColor { get; set; }
        public int happinessStatus { get; set; }
        public string uniformNumberPhoto { get; set; }

        public override string ToString()
        {
            string status_message = "";
            status_message += "Name: " + this.name;






            status_message += ". \r\nYou have selected the following abilities:";
            if (this.specialAbilities[0]) status_message += "Feint, ";
            if (this.specialAbilities[1]) status_message += "Resistant, ";
            if (this.specialAbilities[2]) status_message += "Deception, ";
            if (this.specialAbilities[3]) status_message += "Penalty, ";
            if (this.specialAbilities[4]) status_message += "FreeKick, ";
            if (this.specialAbilities[5]) status_message += "Steal, ";
            if (this.specialAbilities[6]) status_message += "Shooting, ";
            if (this.specialAbilities[7]) status_message += "Sprint, ";



            status_message += "\r\nCountry of the football player: " + country[0];
            status_message += "\r\nPosition: " + position;
            status_message += "\r\nSpeed: " + speed + " Intelligent: " + intelligent + " Age: " + age;
            status_message += "\r\nTransfer Start Date: " + transferStart.Month + "/" + transferStart.Day + "/" + transferStart.Year + "\r\nTransfer Finish Date: " + transferFinish.Month + "/" + transferFinish.Day + "/" + transferFinish.Year;
            status_message += "\r\nYear Experience: " + yearsExperince;
            status_message += "\r\nThe favourite color: " + favouriteColor.ToString();


            if (happinessStatus > 0)
            {
                status_message += "\r\nHappiness Status: Happy" + " Happiness Value: " + happinessStatus;
            }
            else if (happinessStatus < 0)
            {
                status_message += "\r\nHappiness Status: Unhappy" + " Happiness Value: " + happinessStatus;
            }
            else
            {
                status_message += "\r\nHappiness Status: Insensitive" + " Happiness Value: " + happinessStatus;
            }
            status_message += "\r\nThe uniformNumber is: " + uniformNumberPhoto;

            return status_message;
        }

        public int CompareTo(object obj)            //for A->Z sort
        {
            Footballer other = (Footballer)obj;

            return name.CompareTo(other.name);
        }
    }
}
