using SortingAlgorithmsTraining.Abstract;
using System;
using System.Linq;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class QuickSort
    {
        public int[] Sort(int[] collection)
        {
            var currentBorderIndex = DivideCollection(collection);

            Sort(collection.Take(currentBorderIndex).ToArray());
            Sort(collection.Skip(currentBorderIndex).ToArray());

            throw new NotImplementedException();
        }

        public int DivideCollection(int[] unsortedCollection)
        {
            int pivot = unsortedCollection[unsortedCollection.Length - 1];
            int borderIndex = 0;

            for (int i = 0; i < unsortedCollection.Length; i++)
            {
                if (unsortedCollection[i] < pivot)
                {
                    var buffer = unsortedCollection[borderIndex];
                    unsortedCollection[borderIndex] = unsortedCollection[i];
                    unsortedCollection[i] = buffer;
                    borderIndex++;
                }
            }

            var borderBuffer = unsortedCollection[borderIndex];
            unsortedCollection[borderIndex] = pivot;
            unsortedCollection[unsortedCollection.Length - 1] = borderBuffer;

            return borderIndex;
        }
    }
}
