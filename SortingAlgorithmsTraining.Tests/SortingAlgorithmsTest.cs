using NUnit.Framework;
using SortingAlgorithmsTraining.Abstract;
using SortingAlgorithmsTraining.Implementation;
using System.Linq;

namespace SortingAlgorithmsTraining.Tests
{
    public class SortingAlgorithmsTest
    {
        private static int[] _fixedValuesUnsortedArray;
        private static IOrderedEnumerable<int> _fixedValuesSortedArray;

        [SetUp]
        public void Setup()
        {
            _fixedValuesUnsortedArray = new int[] { 4, 91, 2, 0, 36, 11, 6, 6, -3, 71, 42, 8};
            _fixedValuesSortedArray = _fixedValuesUnsortedArray.ToList().OrderBy(n => n);
        }

        [Test]
        public void BubbleSort_WhenFixedCollectionGiven_ShouldSortElements()
        {
            ISortingAlgorithm sortingAlgorithm = new BubbleSort();

            Assert.AreEqual(sortingAlgorithm.Sort(_fixedValuesUnsortedArray), _fixedValuesSortedArray);
        }

        [Test]
        public void InsertionSort_WhenFixedCollectionGiven_ShouldSortElements()
        {
            ISortingAlgorithm sortingAlgorithm = new InsertionSort();

            Assert.AreEqual(sortingAlgorithm.Sort(_fixedValuesUnsortedArray), _fixedValuesSortedArray);
        }

        [Test]
        public void SelectionSort_WhenFixedCollectionGiven_ShouldSortElements()
        {
            ISortingAlgorithm sortingAlgorithm = new SelectionSort();

            Assert.AreEqual(sortingAlgorithm.Sort(_fixedValuesUnsortedArray), _fixedValuesSortedArray);
        }

        [Test]
        public void QuickSort_WhenFixedCollectionGiven_ShouldSortElements()
        {
            ISortingAlgorithm sortingAlgorithm = new QuickSort();

            Assert.AreEqual(sortingAlgorithm.Sort(_fixedValuesUnsortedArray), _fixedValuesSortedArray);
        }

        [Test]
        public void MergeSort_WhenFixedCollectionGiven_ShouldSortElements()
        {
            ISortingAlgorithm sortingAlgorithm = new MergeSort();

            Assert.AreEqual(sortingAlgorithm.Sort(_fixedValuesUnsortedArray), _fixedValuesSortedArray);
        }
    }
}