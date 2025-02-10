using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static session_4_Delegates.BookFunctions;

namespace session_4_Delegates
{
    internal class LibraryEngine
    {
     


        public static void ProcessBooks(List<Book> blist, /*BookFuncDelegate*/Func<Book, string> bookFunc)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(bookFunc(B));
            }
        }
    }
}
