using Session03CollectionP2;
using System.ComponentModel.Design;

namespace CollectionsP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(new int[]{1,2,3,4 });
            Helper.ReverseQueueElementsByStack(q);
        }
    }
}
