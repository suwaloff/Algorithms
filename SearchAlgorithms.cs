namespace Algorithms
{
    public static class SearchAlgorithms
    {
        public static int Linear(int key, int[] Array)
        {

            if (Array is null)
            {
                return -2;
            }
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == key) return i;

            }
            return -1;
        }
        public static int BinaryFind(int key, int[] myArray)
        {
            int first = 0;
            int last = myArray.Length;
            int mid = myArray.Length / 2;

            if (myArray is null)
            {
                return -2;
            }

            while (first <= last)
            {
                mid = (last + first) / 2;

                if (myArray[mid] > key) last = mid - 1;

                else if (myArray[mid] < key) first = mid + 1;

                else break;
            }

            if (myArray[mid] == key) return mid;

            return -1;
        }
    }
}
