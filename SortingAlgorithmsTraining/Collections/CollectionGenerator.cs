using System;

namespace SortingAlgorithmsTraining.Collections
{
    internal static class CollectionGenerator
    {
        internal static int[] GetFixedIntigerCollection()
        {
            return new int[] { 9, 4, 6, 2, 7, 1, 3, 5 };
        }

        internal static int[] GetRandomizedCollection(int collectionSize, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int[] collection = new int[collectionSize];

            for (int i = 0; i < collectionSize; i++)
            {
                collection[i] = new Random().Next(minValue, maxValue);
            }

            return collection;
        }
    }
}
