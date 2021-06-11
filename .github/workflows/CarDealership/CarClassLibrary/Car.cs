using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Brand = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }
        public Car(string a, string b, decimal c)
        {
            Brand = a;
            Model = b;
            Price = c;
        }

    }
}