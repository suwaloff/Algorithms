using Algorithms.Search;
using Algorithms.Sorting.Algorithms;
using Algorithms.Sorting;
using Xunit;

namespace Algorithms.UnitTest.SortingAlgorithmTest
{
    public static class InsertionSortTest
    {
        [Fact]
        public static void Insertion_Array_Test()
        {
            // Arrange
            int[] array =     { 16, 1, 9, 17, 11, 15, 13, 14, 12, 7, 10 };
            int[] sortArray = { 1, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            // Act
            Sorting.Sorting sorting1 = new Sorting.Sorting(new InsertionSort(array));
            sorting1.Sort();

            // Assert
            Assert.Equal(sortArray, array);
        }
    }
}
