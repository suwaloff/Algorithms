namespace Algorithms.Sorting.Algorithms
{
    /// <summary>
    ///     A Coctail Sort algorithm implementation
    /// </summary>
    public class CoctailSort : IStrategy
    {
        private int[] array { get; }

        public CoctailSort(int[] array) => this.array = array;

        public void Sort()
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var swapRequired = false;

                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Helping.Swap(ref array[j], ref array[j + 1]);
                        swapRequired = true;
                    }
                }

                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Helping.Swap(ref array[j], ref array[j - 1]);
                        swapRequired = true;
                    }
                }

                if (!swapRequired) break;

            }
        }
    }
}
