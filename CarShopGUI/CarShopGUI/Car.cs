using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }

        public Car(string cMake,string cModel, decimal cPrice)
        {
            make = cMake;
            model = cModel;
            price = cPrice;
        }
        public Car()
        {
            make = "Nothing yet";
            model = "Nothimg yet";
            price = 0.00m;
        }

        public override string ToString()
        {
            return "Make: " + make + " Model " + model + " Price: $" + price;
        }
    }
}
