using SortingAlgorithmsTraining.BubbleSort;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCollection = { 4, 7, 9, 2, 10, 1, 0, 6, 3, -4, 5, 1, 5 };

            var bubbleSort = new BubbleSortAlgorithm();
            var outputCollection = bubbleSort.Sort(inputCollection);

            Console.WriteLine("Sorting results:");
            Console.WriteLine(string.Join(",", outputCollection));
            Console.Read();
        }
    }
}
