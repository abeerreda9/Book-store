using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store
{
    public class EBook:Book
    {
        public EBook(string iSBN, string title, double price, int year,string filetype) : base(iSBN, title, price, year)
        {
            FileType= filetype;
        }

        public string FileType { get; set; }

        public override double Buy(int quantity, string ISBN, string email, string Address)
        {
            //MailService.Send(email);
            return quantity * Price;
        }
    }
}
