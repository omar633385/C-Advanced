namespace Session01Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            //Console.WriteLine("Original array:");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //OptimizedBubbleSort.Sort(arr);

            //Console.WriteLine("\nSorted array:");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Q2

            // Example with int
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15)); //  True
            Console.WriteLine("Is 5 in range? " + intRange.IsInRange(5));   //  False
            Console.WriteLine("Length of range: " + intRange.Length());       //  10

            // Example with doubles
            Range<double> doubleRange = new Range<double>(5.5, 10.5);
            Console.WriteLine("Is 7.5 in range? " + doubleRange.IsInRange(7.5)); //  True
            Console.WriteLine("Is 3.0 in range? " + doubleRange.IsInRange(3.0)); //  False
            Console.WriteLine("Length of range: " + doubleRange.Length());         //  5.0
            #endregion
        }
    }
}
