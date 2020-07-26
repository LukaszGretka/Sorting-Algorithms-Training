using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmsTraining.Collections
{
    internal static class CollectionGenerator
    {
        internal static int[] GetFixedIntigerCollection()
        {
            return new int[] { 9, 1, 2, 4, 5, 7, 8, 6, 3 };
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
