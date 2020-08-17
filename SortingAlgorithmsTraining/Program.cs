using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var processingCollection = CollectionGenerator.GetRandomizedCollection(50, -100, 100);
            var insertionSort = new SelectionSort();

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join(",", processingCollection));

            insertionSort.Sort(processingCollection);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(",", processingCollection));
            Console.Read();
        }
    }
}
