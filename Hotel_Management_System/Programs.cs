using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Programs
    {
        public static void Main()
        {
            bool isRunning = true;
            do
            {
                Restaurant restaurant = new Restaurant();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Welcome to Sahyadri Restaurant....");
                Console.WriteLine("1. Display Menu..");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. View Order");
                Console.WriteLine("4. Bill");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------------------------------");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        restaurant.displayMenu();
                        Console.WriteLine("----------------------------------------------");
                        break;
                   
                    case 2:
                        restaurant.placeOrder();
                        Console.WriteLine("----------------------------------------------");
                        break;
                    case 3:
                        restaurant.viewOrder();
                        Console.WriteLine("----------------------------------------------");
                        break;
                    
                    case 4:
                        restaurant.billOfOrder();
                        Console.WriteLine("----------------------------------------------");
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Exiting the application. Thank you for visiting Sahyadri Restaurant!");
                        Console.WriteLine("----------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine("----------------------------------------------");
                        break;
                }
            }
            while (isRunning);
        }
    }
}
