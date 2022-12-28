namespace Algorithms.Sorting
{
    public class BubbleSort : IStrategy
    {
        private int[] array { get; }

        public BubbleSort(int[] array)
        {
            this.array = array;
        }

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

                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    swapRequired = true;
                }
                arrayLength--;

            } while (swapRequired == true);
        }
    }
}
