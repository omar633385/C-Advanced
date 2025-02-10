using static session_4_Delegates.BookFunctions;

namespace session_4_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("123", "book 1", new string[] { "omar", "ahmed" }, DateTime.Now, 120);
            List<Book> books = new List<Book>();
            books.Add(b);
            books.Add(new Book("456", "book 2", new string[] { "omar", "ahmed" }, DateTime.Now, 200));
            #region a)	Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            //string result = BookFunctions.GetTitle(b);
            ////step 1
            //BookFuncDelegate del;
            ////step 2
            //del = new BookFuncDelegate(GetTitle);
            //LibraryEngine.ProcessBooks(books, del);

            #endregion

            #region b)	Use the Proper build in delegate. 
            //Func<Book, string> BookFunc;
            //BookFunc = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(books, BookFunc);
            #endregion

            #region c)	Anonymous Method (GetISBN).
            //BookFuncDelegate del = delegate (Book b)
            //{
            //    return b.ISBN;
            //};
            //LibraryEngine.ProcessBooks(books, del.Invoke);

            #endregion

            #region d)	Lambda Expression (GetPublicationDate).

            BookFuncDelegate del = (Book b) => b.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(books, del.Invoke);
            #endregion
        }
    }
}
