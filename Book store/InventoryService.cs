using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public class InventoryService
    {
         List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added");
        }
        public void RemoveBook(int maxyear) { 
        int currentyear=DateTime.Now.Year;
            books.RemoveAll(x => currentyear- x.Year > maxyear);
            Console.WriteLine("Outdated books removed");
        }
        public double BuyBook(string isbn, int quantity, string email, string address)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            
            return book.Buy(quantity,isbn, email, address);
        }
    }
}
