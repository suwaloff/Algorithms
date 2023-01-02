using Algorithms.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.UnitTest.SearchingAlgorithmTest
{

    
    public static class BinaryTest
    {
        [Fact]
        public static void BinarySearchTest_Key_Is_In_Array()
        {
            // Arrange
            int[] array = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }; 
            int key = 15;

            // Act
            int desiredKey = BinarySearch.Search(array,key);

            // Assert
            Assert.Equal(key, desiredKey);
        }

        [Fact]
        public static void BinarySearchTest_Key_ISNT_In_The_Array()
        {
            // Arrange
            int[] array = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int key = 100;

            // Act
            int desiredKey = BinarySearch.Search(array, key);

            // Assert
            Assert.Equal(-1, desiredKey);
        }

    }
}
