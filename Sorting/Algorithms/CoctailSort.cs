namespace Algorithms.Sorting.Algorithms
{
    public class CoctailSort : IStrategy
    {
        private int[] array { get; }

        public CoctailSort(int[] array) => this.array = array;

        public void Sort()
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapRequired = false;

                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapRequired = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        swapRequired = true;
                    }
                }

                if (!swapRequired) break;

            }
        }
        static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }

    }
}
//do
//{
//    swapRequired = false;

//    for (; start < end - 1; start++)
//    {
//        if (array[start] > array[start + 1])
//            (array[start], array[start + 1]) = (array[start + 1], array[start]);
//        swapRequired = true;
//    }
//    end--;
//    for (; end > start; end--)
//    {
//        if (array[end] < array[end - 1])

//            (array[end], array[end - 1]) = (array[end - 1], array[end]);
//        swapRequired = true;
//    }
//    start++;

//} while (swapRequired == true);