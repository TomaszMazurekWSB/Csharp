using System;

namespace CarDealerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();


            Console.WriteLine("Welcome to the Car Dealership. First you have to create inventory, later you will be able to add cars to the cart and we will tell you the total value");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose " + action);
               
                switch( action)
                {
                    //add cars to inventory
                    case 1:

                        Console.WriteLine("You chose to add a new car to the inventory.");

                        String carBrand = "";
                        String carModel = "";
                        Decimal carYear = 0;
                        Decimal carKilometers = 0;
                        Decimal carPrice = 0;

                        Console.WriteLine("What is the brand of the car?");
                        carBrand = Console.ReadLine();

                        Console.WriteLine("What is the car model?");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the cars production year?");
                        carYear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Hom may kilometers have been driven in this car?");
                        carKilometers = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the price of the car?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carBrand, carModel, carYear, carKilometers, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;


                    //add to shopping cart
                    case 2:

                        Console.WriteLine("You chose to add a new car to your shopping cart. ");
                        printInventory(s);
                        Console.WriteLine(" Which vehicle would you like to buy? (pick a number)");
                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]);

                        printShoppingCart(s);

                        break;

                    //checkout
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());




                        break;

                    default:
                        
                        break;


                }
                action = chooseAction();

            }

        static void printShoppingCart(Store s)
        {
                Console.WriteLine("Cars you have chosen to buy: ");
                for (int i = 0; i < s.ShoppingList.Count; i++)
                {

                    Console.WriteLine("Car #  " + i + " " + s.ShoppingList[i]);
                }
        }




        static void printInventory(Store s)
        {
           for(int i = 0; i < s.CarList.Count; i++)
            {
               
                Console.WriteLine("Car #  " + i + " " + s.CarList[i]);
            }
        }
            
        static int chooseAction()
            {
                int choice = 0;
                Console.WriteLine("Choose an action (0) to quit (1) to add a new car (2) add to cart and (3) to checkout");

                choice = int.Parse(Console.ReadLine());
                return choice;

            }
        }
    }
}
