using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01Generics
{
    internal class OptimizedBubbleSort
    {
       public static void Sort(int[] arr)
        {
            int n = arr.Length;
            bool isswapped;

            for (int i = 0; i < n - 1; i++)
            {
                isswapped = false;

                // Last i elements are already sorted, so we don't need to check them
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isswapped = true;
                    }
                }

                // If no two elements were swapped by inner loop, then the array is sorted
                if (!isswapped)
                    break;
            }
        }
    }
}
