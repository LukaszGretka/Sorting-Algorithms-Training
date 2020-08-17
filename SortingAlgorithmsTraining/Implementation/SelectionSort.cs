using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class SelectionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processedCollection)
        {
            for (int outerIndex = 1; outerIndex < processedCollection.Length; outerIndex++)
            {
                var minValue = processedCollection[outerIndex - 1];
                var minValueIndex = outerIndex - 1;

                for (int innerIndex = outerIndex; innerIndex < processedCollection.Length; innerIndex++)
                {
                    if (processedCollection[innerIndex] < minValue)
                    {
                        minValue = processedCollection[innerIndex];
                        minValueIndex = innerIndex;
                    }
                }

                var buffer = processedCollection[outerIndex - 1];
                processedCollection[outerIndex - 1] = processedCollection[minValueIndex];
                processedCollection[minValueIndex] = buffer;
            }

            return processedCollection;
        }
    }
}
