namespace Algorithms.Sorting.Algorithms
{
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
            if (start >= end)
            {
                return;
            }
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
                    Swap(ref array[pivot], ref array[i]);
                    pivot++;
                }
            }

            Swap(ref array[pivot], ref array[end]);

            return pivot;
        }

        static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }
    }
}
