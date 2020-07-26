using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class QuickSort : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedCollection)
        {
            int pivot = unsortedCollection[unsortedCollection.Length - 1];
            int borderIndex = 0;

            for (int i = 0; i < unsortedCollection.Length; i++)
            {
                if (pivot > unsortedCollection[i])
                {
                    var buffer = unsortedCollection[i - 1];
                    unsortedCollection[i - 1] = unsortedCollection[i];
                    unsortedCollection[i] = buffer;
                    borderIndex++;
                }
            }

            var borderBuffer = unsortedCollection[borderIndex];
            unsortedCollection[borderIndex] = pivot;
            unsortedCollection[unsortedCollection.Length - 1] = borderBuffer;

            return unsortedCollection;
        }
    }
}
