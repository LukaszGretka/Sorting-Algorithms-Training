using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class BubbleSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processingCollection)
        {
            for (int index = 0; index < processingCollection.Length; index++)
            {
                for (int i = 0; i < processingCollection.Length - 1; i++)
                {
                    if (processingCollection[i] > processingCollection[i + 1])
                    {
                        var buffer = processingCollection[i + 1];
                        processingCollection[i + 1] = processingCollection[i];
                        processingCollection[i] = buffer;
                    }
                }
            }

            return processingCollection;
        }
    }
}
