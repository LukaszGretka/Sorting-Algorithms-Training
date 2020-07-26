using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var quickSort = new QuickSort();

            var outputCollection = quickSort.Sort(CollectionGenerator.GetFixedIntigerCollection());

            Console.WriteLine("Sorting results:");
            Console.WriteLine(string.Join(",", outputCollection));
            Console.Read();
        }
    }
}
