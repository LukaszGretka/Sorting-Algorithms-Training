using SortingAlgorithmsTraining.Abstract;
using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var processingCollection = CollectionGenerator.GetRandomizedCollection(10, 1, 20);

            ISortingAlgorithm sortingAlgorithm = new SelectionSort();

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join(",", processingCollection));

            processingCollection = sortingAlgorithm.Sort(processingCollection);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"{sortingAlgorithm.GetType().UnderlyingSystemType.Name} completed.");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Sorted array:");
            Console.WriteLine(string.Join(",", processingCollection));
            Console.Read();
        }
    }
}
