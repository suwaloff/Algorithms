namespace Algorithms.Search
{
    /// <summary>
    ///     A binary search algorithm implementation
    /// </summary>
    public class BinarySearch
    {
        public static int Search(int[] array, int key)
        {
            int first = 0;
            int last = array.Length - 1;
            int mid = 0;

            while (first <= last)
            {
                mid = (last + first) / 2;

                if (array[mid] > key) last = mid - 1;

                else if (array[mid] < key) first = mid + 1;

                else break;
            }

            if (array[mid] == key) return key;

            return -1;
        }
    }
}

