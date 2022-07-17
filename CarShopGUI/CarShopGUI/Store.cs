using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    class Store
    {
        public List<Car> carList { get; set; }
        public List<Car> shoppingList { get; set; }

        public Store()
        {
            carList = new List<Car>();
            shoppingList = new List<Car>();
        }
        public decimal checkout()
        {
            decimal totalCost = 0;

            foreach (var item in shoppingList)
            {
                totalCost += item.price;
            }
            shoppingList.Clear();
            return totalCost;
        }

    }
}
