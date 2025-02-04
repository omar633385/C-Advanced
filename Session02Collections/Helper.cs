using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session02Collections
{
    internal class Helper
    {
        #region Question1
        public static ArrayList ReverseArrayList(ArrayList list)
        {
            ArrayList ReversedArray = new ArrayList(list.Capacity);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                ReversedArray.Add(list[i]);
            }
            return ReversedArray;
        }
        #endregion

        #region Question 2

        public static List<int> GetEvenNumbers(List<int> Numbers)
        {
            List<int> EvenNumbers = new List<int>();

            foreach (var item in Numbers)
            {
                if (item % 2 == 0)
                    EvenNumbers.Add(item);
            }
            return EvenNumbers;
        }
        #endregion

        #region Question 4
        public static int GetIndexOfFirstUnRepeatedChar(string str)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                    dict[c] = 1;
                else
                    dict[c]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (dict[str[i]] == 1)
                    return i;
            }
            return -1;
        }

        #endregion

        #region Question 5
        public static void print_how_many_numbers_in_array_that_is_greater_than_X(int[] Numbers, int No_Of_Queries)
        {
            List<int> list = new List<int>(No_Of_Queries);
            for (int i = 0; i < No_Of_Queries; i++)
            {
                int no; bool flag;

                do
                {
                    Console.Write($"Enter Query {i + 1}: ");
                    flag = int.TryParse(Console.ReadLine(), out no);
                    if (!flag)
                        Console.WriteLine("Enter valid inputs it only accepts integer values");
                } while (!flag);
                list.Add(no);
            }

            foreach (var query in list)
            {
                int count = 0;
                foreach (var no in Numbers)

                {
                    if (no > query)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
            #endregion


        }
    }
}
