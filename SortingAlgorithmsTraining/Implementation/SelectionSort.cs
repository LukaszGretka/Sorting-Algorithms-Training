using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class SelectionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processingCollection)
        {
            for (int outerIndex = 1; outerIndex < processingCollection.Length; outerIndex++)
            {
                var minValue = processingCollection[outerIndex - 1];
                var minValueIndex = outerIndex - 1;

                for (int innerIndex = outerIndex; innerIndex < processingCollection.Length; innerIndex++)
                {
                    if (processingCollection[innerIndex] < minValue)
                    {
                        minValue = processingCollection[innerIndex];
                        minValueIndex = innerIndex;
                    }
                }

                var buffer = processingCollection[outerIndex - 1];
                processingCollection[outerIndex - 1] = processingCollection[minValueIndex];
                processingCollection[minValueIndex] = buffer;
            }

            return processingCollection;
        }
    }
}
