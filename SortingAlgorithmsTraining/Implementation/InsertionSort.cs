using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class InsertionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processingCollection)
        {
            var sortedCollectionLenght = 1;

            for (int index = 1; index < processingCollection.Length; index++)
            {
                var movementIndex = 0;
                var buffer = processingCollection[sortedCollectionLenght];

                for (int innerIndex = 0; innerIndex < sortedCollectionLenght; innerIndex++)
                {
                    var insertingElement = processingCollection[sortedCollectionLenght - 1 - movementIndex];

                    if (buffer < insertingElement)
                    {
                        processingCollection[sortedCollectionLenght - movementIndex] = insertingElement;
                        movementIndex++;
                    }
                }

                processingCollection[sortedCollectionLenght - movementIndex] = buffer;
                sortedCollectionLenght++;
            }

            return processingCollection;
        }
    }
}
