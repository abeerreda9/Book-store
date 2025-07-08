using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public class ShippingService
    {
        public void ship(string address)
        {
            Console.WriteLine($"Shipping paper book to {address}");
        }
    }
}
