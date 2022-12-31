namespace Algorithms.Search
{
    public class BinarySearch : IStrategy
    {
        public int Search(int key, int[] array)
        {
            int first = 0;
            int last = array.Length;
            int mid = 0;

            //if (array is null)
            //{
            //    return -1;
            //}

            while (first <= last)
            {
                mid = (last + first) / 2;

                if (array[mid] > key) last = mid - 1;

                else if (array[mid] < key) first = mid + 1;

                else break;
            }

            if (array[mid] == key) return mid;

            return -1;
        }
    }
}

