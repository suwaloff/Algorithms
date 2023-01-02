namespace Algorithms.Sorting.Algorithms
{
    /// <summary>
    ///     A Quick Sort algorithm implementation
    /// </summary>
    public class QuickSort : IStrategy
    {
        private int[] array { get; }
        int minIndex { get; set; }
        int maxIndex { get; set; }
        public QuickSort(int[] array, int minIndex, int maxIndex)
        {
            this.array = array;
            this.minIndex = minIndex;
            this.maxIndex = maxIndex;
        }

        public void Sort()
        {
            Quicksort(array, minIndex, maxIndex);
        }
        void Quicksort(int[] array, int start, int end)
        {
            if (start >= end) return;
           
            int pivot = Partition(array, start, end);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        }

        int Partition(int[] array, int start, int end)
        {
            int pivot = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end])
                {
                    Helping.Swap(ref array[pivot], ref array[i]);
                    pivot++;
                }
            }

            Helping.Swap(ref array[pivot], ref array[end]);

            return pivot;
        }
    }
}
