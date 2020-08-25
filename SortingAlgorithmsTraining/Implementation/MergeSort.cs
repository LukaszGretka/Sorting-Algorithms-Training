using System;

namespace SortingAlgorithmsTraining.Implementation
{
    internal class MergeSort
    {
        internal int[] Sort(int[] processingCollection, int elementCount)
        {
            var splitArrayResult = SplitArray(processingCollection);

            var leftArray = splitArrayResult.Item1;
            var rightArray = splitArrayResult.Item2;

            if (elementCount > 1)
            {
                leftArray = Sort(leftArray, leftArray.Length);
                rightArray = Sort(rightArray, rightArray.Length);
                processingCollection = Merge(leftArray, rightArray);
            }

            return processingCollection;
        }

        private int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] outputArray = new int[leftArray.Length + rightArray.Length];

            int leftArrayCurrentIndex = default;
            int rightArrayCurrentIndex = default;
            int outputArrayCurrentIndex = default;

            while (leftArrayCurrentIndex < leftArray.Length && rightArrayCurrentIndex < rightArray.Length)
            {
                if (leftArray[leftArrayCurrentIndex] > rightArray[rightArrayCurrentIndex])
                {
                    outputArray[outputArrayCurrentIndex] = rightArray[rightArrayCurrentIndex];
                    rightArrayCurrentIndex++;
                }
                else
                {
                    outputArray[outputArrayCurrentIndex] = leftArray[leftArrayCurrentIndex];
                    leftArrayCurrentIndex++;
                }

                outputArrayCurrentIndex++;
            }

            while (rightArrayCurrentIndex < rightArray.Length)
            {
                outputArray[outputArrayCurrentIndex] = rightArray[rightArrayCurrentIndex];
                outputArrayCurrentIndex++;
                rightArrayCurrentIndex++;
            }

            while(leftArrayCurrentIndex < leftArray.Length)
            {
                outputArray[outputArrayCurrentIndex] = leftArray[leftArrayCurrentIndex];
                outputArrayCurrentIndex++;
                leftArrayCurrentIndex++;
            }

            return outputArray;
        }

        private Tuple<int[], int[]> SplitArray(int[] array)
        {
            var leftArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length / 2; i++)
            {
                leftArray[i] = array[i];
            }

            var rightArray = new int[array.Length - leftArray.Length];

            for (int j = leftArray.Length; j < array.Length; j++)
            {
                rightArray[j - leftArray.Length] = array[j];
            }

            return new Tuple<int[], int[]>(leftArray, rightArray);
        }
    }
}
