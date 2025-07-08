using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public abstract class Book
    {
        public Book(string iSBN, string title, double price, int year)
        {
            ISBN = iSBN;
            Title = title;
            Price = price;
            Year = year;
        }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public abstract double Buy(int quantity, string ISBN, string email,string Address);



    }
}
