using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public class ShowcaseBook : Book
    {

        public ShowcaseBook(string iSBN, string title, double price, int year) : base(iSBN, title, price, year)
        {
        }

        public override double Buy(int quantity, string ISBN, string email, string Address)
        {
           throw new Exception("Showcase books are not for sale");
        }
    }
}
