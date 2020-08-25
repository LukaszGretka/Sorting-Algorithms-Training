using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var processingCollection = CollectionGenerator
                                       //.GetFixedIntigerCollection();
                                       .GetRandomizedCollection(10, 1, 20);

            var mergeSort = new MergeSort();

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join(",", processingCollection));

            processingCollection = mergeSort.Sort(processingCollection, processingCollection.Length);

            Console.WriteLine($"{nameof(MergeSort)} completed. Sorted array:");
            Console.WriteLine(string.Join(",", processingCollection));
            Console.Read();

        }

    }
}
