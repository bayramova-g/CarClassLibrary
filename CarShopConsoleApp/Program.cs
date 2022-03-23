using System;
using CarClassLibrary;

namespace CarShopConsoleApp
{

    class Program
    {

        static void Main(string[] args)
        {

            Store s = new Store();
            Console.WriteLine("Welcome to the car store");
            int action = chooseAction();
            while (action!=0)
            {
                Console.WriteLine("You chose"+action);

                switch (action)
                {

                    //add item to invetory
                    case 1:
                        Console.WriteLine( "You choose to add a new car to the inventory  ");

                        string carMake = " ";
                        string carModel = " ";
                        string carColor = " ";
                        byte carYear = 0;
                        decimal carPrice =0;


                        Console.WriteLine("What is the car make?BMW,Mercedes,Ford,Range Rover,Toyota,Nissan etc");
                        carMake = Console.ReadLine();



                        Console.WriteLine("What is the car model?5 series,4series,X5,X6Mercedes,Mustang,Camry,Stringer etc");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car color?White,black,grey,blue");
                        carColor = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the car year?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice,carYear, carColor);

                        s.CarList.Add(newCar);

                        printInventory(s);

            
                        break;


                    //add to cart

                    case 2:

                        Console.WriteLine("You choose to add a cart to you shopping cart");


                        printInventory(s);

                        Console.WriteLine("which item would you like to buy?(number)");

                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]);
                        printShoppingCart(s);
                        break;


                    //checkout
                    case 3:

                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is :  "  + s.CheckOut());

                 
break;

                    default:
                        break;

                }


                action = chooseAction();
            }

        }

        private static void printShoppingCart(Store s)
        {

            Console.WriteLine("Cars you have chosen to buy");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car #" + i + " " + s.ShoppingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for(int i=0;i<s.CarList.Count;i++)
            {
                Console.WriteLine("Car #"+i+" "+s.CarList[i]);
            }
        }

        static public int chooseAction()
        {

            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) and a new car to inventory(2) add car to cart(3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }



    }
}
