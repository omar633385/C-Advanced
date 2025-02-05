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


        #region Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in str)
            {
                if (item == '(' || item == '{' || item == '[')
                    stack.Push(item);
                else
                {
                    if (stack.Count > 0 &&
                        ((stack.Peek() == '(' && item == ')') ||
                         (stack.Peek() == '{' && item == '}') ||
                         (stack.Peek() == '[' && item == ']')))

                        stack.Pop();

                    else
                        return false;

                }

            }
            return stack.Count == 0;
        } 
        #endregion

    }
}
