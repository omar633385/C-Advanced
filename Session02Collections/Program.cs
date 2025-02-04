using System.Collections;
using System.Collections.Generic;

namespace Session02Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ///1.	You are given an ArrayList containing a sequence of elements.
            ///try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            ///    without using the built-in Reverse.
            ///    Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.


            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //ArrayList reversedList = Helper.ReverseArrayList(arrayList);

            //foreach (var item in reversedList)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> Numbers = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            //List<int>EvenNumbers= Helper.GetEvenNumbers(Numbers);
            //foreach (var item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            //int capacity = 3;
            //FixedSizeList<int> list=new FixedSizeList<int> (capacity);
            //try
            //{
            //    list.Add (0);
            //    list.Add(1);
            //    list.Add(2);
            //    list.Add(3);
            //    list.GetValue(5);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Q4

            //int idx = Helper.GetIndexOfFirstUnRepeatedChar("yoyo");
            //Console.WriteLine(idx);


            #endregion

            #region Q5
            //    int ArrayLength;
            //    int No_Of_Queries;
            //    bool flag;
            //    do
            //    {
            //        Console.WriteLine("Enter The Array Size");
            //        flag = int.TryParse(Console.ReadLine(), out ArrayLength);
            //        if (!flag)
            //            Console.WriteLine("Enter Valid Input for Array Size");
            //    } while (!flag);
            //    do
            //    {
            //        Console.WriteLine("Enter The No_Of_Queries");

            //        flag = int.TryParse(Console.ReadLine(), out No_Of_Queries);
            //        if (!flag)
            //            Console.WriteLine("Enter Valid Input for No_Of_Queries");
            //    } while (!flag);
            //    int[] Numbers = new int[ArrayLength];
            //    for (int i = 0; i < ArrayLength; i++)
            //    {
            //        do
            //        {
            //            Console.Write($"Enter Array Element no {i + 1}: ");
            //            flag = int.TryParse(Console.ReadLine(), out Numbers[i]);
            //            if (!flag)
            //                Console.WriteLine("Enter valid input for array it only accept integer values");
            //        } while (!flag);
            //    }
            //    Helper.print_how_many_numbers_in_array_that_is_greater_than_X(Numbers, No_Of_Queries);

            //}
            #endregion

            #region Q6
            bool flag;
            int ArrayLength;
            do
            {
                Console.WriteLine("Enter The Array Size");
                flag = int.TryParse(Console.ReadLine(), out ArrayLength);
                if (!flag)
                    Console.WriteLine("Enter Valid Input for Array Size");
            } while (!flag);
            int[] Numbers = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                do
                {
                    Console.Write($"Enter Array Element no {i + 1}: ");
                    flag = int.TryParse(Console.ReadLine(), out Numbers[i]);
                    if (!flag)
                        Console.WriteLine("Enter valid input for array it only accept integer values");
                } while (!flag);
            }
            if(Helper.IsPalindrome(Numbers))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            #endregion
        }



    }
}

