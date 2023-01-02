using Algorithms.Search;
using Xunit;

namespace Algorithms.UnitTest.SearchingAlgorithmTest
{
    public static class JumpTest
    {
        [Fact]
        public static void JumpSearchTest_Key_Is_In_The_Array()
        {
            // Arrange
            int[] array = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int key = 16;

            // Act
            int desiredKey = JumpSearch.Search(array, key);

            // Assert
            Assert.Equal(key, desiredKey);
        }
        [Fact]
        public static void JumpSearchTest_Key_ISNT_In_The_Array()
        {
            // Arrange
            int[] array = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int key = 25;

            // Act
            int desiredKey = JumpSearch.Search(array, key);

            // Assert
            Assert.Equal(-1, desiredKey);
        }
    }
}
