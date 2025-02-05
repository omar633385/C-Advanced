using Session03CollectionP2;
using System.ComponentModel.Design;

namespace CollectionsP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Queue<int> q = new Queue<int>(new int[] { 1, 2, 3, 4 });
            //Helper.ReverseQueueElementsByStack(q); 
            #endregion
            #region Q2
            string s = "[()]{}";
            if (Helper.IsBalanced(s))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
            #endregion
        }
    }
}
