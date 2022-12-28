namespace Algorithms.Sorting
{
    public class Qsort : IStrategy
    {
        private int[] array { get; }
        int minIndex { get; set; }
        int maxIndex { get; set; }
        public Qsort(int[] array, int minIndex, int maxIndex)
        {
            this.array = array;
            this.minIndex = minIndex;
            this.maxIndex = maxIndex;
        }
      
        public void Sort()
        {
            quicksort(array, minIndex, maxIndex);

        }
        int partition(int[] array, int start, int end)
        {
            int pivot = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) 
                {
                    (array[pivot], array[i]) = (array[i], array[pivot]);
                    pivot++;
                }
            }
          
            (array[pivot], array[end]) = (array[end], array[pivot]);

            return pivot;
        }

        void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }

    }
}
