using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public class PaperBook : Book
    {
        public PaperBook(string iSBN, string title, double price, int year,int stock) : base(iSBN, title, price, year)
        {
            Stock = stock;
        }

        public int Stock { get; set; }
        public override double Buy(int quantity, string ISBN, string email, string Address)
        {
            if (quantity > Stock) {
                Console.WriteLine("Not Enough stock");
               
            }
            Stock -= quantity;
            // ShippingService.Ship(address);
            return quantity * Price;

        }
    }
}
