namespace Algorithms.Sorting.Algorithms
{
    public class InsertionSort : IStrategy
    {
        public int[] array { get; }

        public InsertionSort(int[] array) => this.array = array;

        public void Sort()
        {

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;

                for (int nextIndex = i + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (array[nextIndex] < array[minIndex])
                    {
                        minIndex = nextIndex;
                    }
                }

                Helping.Swap(ref array[i], ref array[minIndex]);
            }

        }

    }
}
