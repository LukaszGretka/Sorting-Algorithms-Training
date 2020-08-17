using SortingAlgorithmsTraining.Abstract;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class InsertionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] processedCollection)
        {
            var sortedCollectionLenght = 1;

            for (int index = 1; index < processedCollection.Length; index++)
            {
                var movementIndex = 0;
                var buffer = processedCollection[sortedCollectionLenght];

                for (int innerIndex = 0; innerIndex < sortedCollectionLenght; innerIndex++)
                {
                    var insertingElement = processedCollection[sortedCollectionLenght - 1 - movementIndex];

                    if (buffer < insertingElement)
                    {
                        processedCollection[sortedCollectionLenght - movementIndex] = insertingElement;
                        movementIndex++;
                    }
                }

                processedCollection[sortedCollectionLenght - movementIndex] = buffer;
                sortedCollectionLenght++;
            }

            return processedCollection;
        }
    }
}
