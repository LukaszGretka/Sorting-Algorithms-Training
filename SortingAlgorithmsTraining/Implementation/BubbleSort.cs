using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class BubbleSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processedCollection)
        {
            for (int index = 0; index < processedCollection.Length; index++)
            {
                for (int i = 0; i < processedCollection.Length - 1; i++)
                {
                    if (processedCollection[i] > processedCollection[i + 1])
                    {
                        var buffer = processedCollection[i + 1];
                        processedCollection[i + 1] = processedCollection[i];
                        processedCollection[i] = buffer;
                    }
                }
            }

            return processedCollection;
        }
    }
}
