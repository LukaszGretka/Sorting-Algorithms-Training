using System;
using System.Linq;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class QuickSort
    {
        public void Sort(int[] processedCollection, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                var currentBorderIndex = DivideCollection(processedCollection, startIndex, endIndex);

                Sort(processedCollection, startIndex, currentBorderIndex - 1);
                Sort(processedCollection, currentBorderIndex + 1, endIndex);
            }
        }

        public int DivideCollection(int[] processedCollection, int startIndex, int endIndex)
        {
            int pivot = processedCollection[endIndex];
            int borderIndex = startIndex - 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (processedCollection[i] <= pivot)
                {
                    borderIndex++;
                    var buffer = processedCollection[borderIndex];
                    processedCollection[borderIndex] = processedCollection[i];
                    processedCollection[i] = buffer;
                }
            }

            var borderBuffer = processedCollection[borderIndex + 1];
            processedCollection[borderIndex + 1] = processedCollection[endIndex];
            processedCollection[endIndex] = borderBuffer;

            return borderIndex + 1;
        }
    }
}
