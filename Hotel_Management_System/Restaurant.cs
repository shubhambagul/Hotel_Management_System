using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Restaurant
    {
        private List<Menu> menu = new List<Menu>();
        private static List<OrderItem> orderItems = new List<OrderItem>();

        public void listOfMenuItem()
        {
            Console.WriteLine("----------------------------------------------");
            menu.Add(new Menu(1, "Aloo Chaat", 250));
            menu.Add(new Menu(2, "Butter Chicken", 230));
            menu.Add(new Menu(3, "Chole Bhature", 270));
            menu.Add(new Menu(4, "Hyderabadi Biryani", 210));
            menu.Add(new Menu(5, "Garlic Naan", 50));
            menu.Add(new Menu(6, "Missi Roti ", 20));
            menu.Add(new Menu(7, "Jeera Rice", 220));
            menu.Add(new Menu(8, "Lachha Paratha", 120));
            menu.Add(new Menu(9, "Rogan Josh", 170));
            menu.Add(new Menu(10, "Masala Papad", 90));
            menu.Add(new Menu(11, "Samosa", 60));


        }
        public void displayMenu()
        {
            try
            {
                listOfMenuItem();
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Error occurring to display Menu");
            }
        }
        public void placeOrder()
        {
            try
            {
                listOfMenuItem();
                Console.WriteLine("Enter the item number you want to order");
                int itemId = int.Parse(Console.ReadLine());

                foreach (var item in menu)
                {
                    if (itemId == item.id)
                    {
                        Menu selectItem = item;
                        if (selectItem != null)
                        {
                            Console.WriteLine("Enter the Quantity");
                            int Quantity = int.Parse(Console.ReadLine());
                            orderItems.Add(new OrderItem(selectItem, Quantity));
                            Console.WriteLine($"{selectItem.name} is added on your order");

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Error occurring to Add order");
            }
        }

        public void viewOrder()
        {
            try
            {
                if (orderItems.Count > 0)
                {
                    Console.WriteLine("**********View Your Order.....************");

                    foreach (var items in orderItems)
                    {
                        Console.WriteLine(items);
                    }
                }
                else
                {
                    Console.WriteLine("Order Not yet Placed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occuring for view the order " + ex.Message);
            }
        }
        
        public void billOfOrder()
        {
            try
            {
                Console.WriteLine("************** Bill *****************");
                double totalBill = 0;
                foreach (var items in orderItems)
                {
                    Console.WriteLine($"{items} , Amount : {items.getTotalPrice()}");
                    totalBill = totalBill + items.getTotalPrice();
                   
                }
                Console.WriteLine("Total Amount :" + totalBill);
                Console.WriteLine("Thank you for your order , Please proceed to your payment........");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured during the payment " + ex.Message);
            }
        }
        
    }
}
