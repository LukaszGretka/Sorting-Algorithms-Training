using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var processingCollection = CollectionGenerator.GetFixedIntigerCollection();
            var quickSort = new QuickSort();
            quickSort.Sort(processingCollection, 0, processingCollection.Length - 1);

            Console.WriteLine("Sorting results:");
            Console.WriteLine(string.Join(",", processingCollection));
            Console.Read();
        }
    }
}
