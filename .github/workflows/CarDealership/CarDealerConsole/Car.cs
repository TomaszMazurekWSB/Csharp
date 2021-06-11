namespace CarDealerConsole
{
    internal class Car
    {
            
            public string Brand { get; set; }
            public string Model { get; set; }
            public decimal Year { get; set; }
            public decimal Kilometers { get; set;}

            public decimal Price { get; set; }
            

            public Car()
            {
                Brand = "nothing yet";
                Model = "nothing yet";
                Year = 0M;
                Kilometers = 0M;
                Price = 0.00M;
            }
            public Car(string a, string b, decimal y, decimal k,decimal c)
            {
                Brand = a;
                Model = b;
                Year = y;
                Kilometers = k;
                Price = c;
            }

        override public string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " Year: " + Year + " Kilometers: " + Kilometers + " Price: $ " + Price;
        }       

    }
}