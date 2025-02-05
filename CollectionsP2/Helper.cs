using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03CollectionP2
{
    public class Helper
    {
        #region Given a Queue, implement a function to reverse the elements of a queue using a stack.

        public static void ReverseQueueElementsByStack<T>(Queue<T> q)
        {
            if (q is not null)
            {
                Stack<T> stack = new Stack<T>();
                while (q.TryDequeue(out T element))
                {
                    stack.Push(element);
                }

                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("Queue Is Empty");
        }
        #endregion

    }
}
