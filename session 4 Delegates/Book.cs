using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_4_Delegates
{
    internal class Book
    {


        #region Properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        #endregion
        #region Constructor
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        #endregion
        public override string ToString()
        {
            return $"ISBN:{ISBN} :: Title:{Title}:: Price:{Price}:: PublicationDate:{PublicationDate}";
        }
    }
}
