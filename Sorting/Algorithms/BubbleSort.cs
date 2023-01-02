namespace Algorithms.Sorting.Algorithms
{
    /// <summary>
    ///  A Coctail Sort algorithm implementation
    ///  *Time complexity: O(n^2)*
    /// </summary>
    public class BubbleSort : IStrategy
    {
        public int[] array { get; }

        public BubbleSort(int[] array) => this.array = array;
        
        public void Sort()
        {
            int arrayLength = array.Length;
            bool swapRequired;
            do
            {
                swapRequired = false;

                for (int i = 0; i < arrayLength - 1; i++)
                {
                    if (array[i] > array[i + 1])

                     Helping.Swap(ref array[i], ref array[i + 1]);
                    swapRequired = true;
                }
                arrayLength--;

            } while (swapRequired == true);
        }
    }
}
