using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class BubbleSort : ISortingAlgorithm
    {
        public int[] Sort(int[] collection)
        {
            for (int index = 0; index < collection.Length; index++)
            {
                for (int i = 0; i < collection.Length - 1; i++)
                {
                    if (collection[i] > collection[i + 1])
                    {
                        var buffer = collection[i + 1];
                        collection[i + 1] = collection[i];
                        collection[i] = buffer;
                    }
                }
            }

            return collection;
        }
    }
}
