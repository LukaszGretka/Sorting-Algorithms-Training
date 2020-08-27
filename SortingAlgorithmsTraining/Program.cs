using SortingAlgorithmsTraining.Abstract;
using SortingAlgorithmsTraining.Collections;
using SortingAlgorithmsTraining.Implementation;
using System;
using System.Diagnostics;

namespace SortingAlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = GetUserInputAlgorithSelection();
            var sortingAlgorithm = GetSortingAlgorithmImplementation(int.TryParse(inputNumber, out int number) ? number : 0);
            var processingCollection = CollectionGenerator.GetRandomizedCollection(1000000, 1, 200000);

            Stopwatch stopwatch = Stopwatch.StartNew();
            sortingAlgorithm.Sort(processingCollection);
            stopwatch.Stop();

            DisplaySortingResults(sortingAlgorithm, stopwatch.ElapsedMilliseconds);
        }

        private static ISortingAlgorithm GetSortingAlgorithmImplementation(int number)
        {
            switch (number)
            {
                case 1: return new BubbleSort();
                case 2: return new InsertionSort();
                case 3: return new SelectionSort();
                case 4: return new MergeSort();
                case 5: return new QuickSort();
                default:
                    Console.Write(Environment.NewLine);
                    Console.WriteLine($"Invalid algorithm number has been selected. Performing default algorithm: {nameof(QuickSort)}");
                    return new QuickSort();
            }
        }

        private static string GetUserInputAlgorithSelection()
        {
            Console.WriteLine("Enter sorting algorithm number to start processing");
            Console.WriteLine($"1. {nameof(BubbleSort)}");
            Console.WriteLine($"2. {nameof(InsertionSort)}");
            Console.WriteLine($"3. {nameof(SelectionSort)}");
            Console.WriteLine($"4. {nameof(MergeSort)}");
            Console.WriteLine($"5. {nameof(QuickSort)}");

            Console.Write("Select number [1-5]: ");
            return Console.ReadLine();
        }

        private static void DisplaySortingResults(ISortingAlgorithm sortingAlgorithm, long executionTime)
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Memory usage: {Process.GetCurrentProcess().PrivateMemorySize64 / 1048} KB");
            Console.WriteLine($"{sortingAlgorithm.GetType().UnderlyingSystemType.Name} completed. Time elapsed: {executionTime} ms");
            Console.WriteLine("-------------------------");
            Console.Read();
        }
    }
}
