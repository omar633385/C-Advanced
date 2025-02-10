using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_4_Delegates
{
    internal class BookFunctions
    {
        //step 0
        public delegate string BookFuncDelegate(Book B);
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string[] GetAuthors(Book B) {

            return B.Authors;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
