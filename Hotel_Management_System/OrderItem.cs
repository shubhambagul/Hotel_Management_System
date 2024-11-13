using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class OrderItem
    {
        Menu menu { get; set; }
        int Quantity { get; set; }

        public OrderItem(Menu menu, int Quantity)
        {
            this.menu = menu;
            this.Quantity = Quantity;
        }

        public double getTotalPrice()
        {
            return menu.price * Quantity;
        }
        public override string ToString()
        {
            return $"{menu} : Quantity : {Quantity}";
        }
    }
}
