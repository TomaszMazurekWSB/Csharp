using System.Collections.Generic;

namespace CarDealerConsole
{
    internal class Store
    {
        public  List<Car> CarList { get; set; }
        public  List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

            public decimal Checkout()
        {
            //initialize the total cost
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;

            }
            ShoppingList.Clear();

            return totalCost;

        }
    }
}