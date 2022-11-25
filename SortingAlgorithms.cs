namespace Algorithms
{

    public static class SortingAlgorithms
    {
        public static void BubbleSortDW(int[] myArray)
        {
            int arrayLength = myArray.Length;
            bool isNeedSorting = true;
            int transpositionIndexArray;

            do
            {
                transpositionIndexArray = 0;

                for (int i = 0; i < arrayLength - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])

                        (myArray[i], myArray[i + 1]) = (myArray[i + 1], myArray[i]);
                    transpositionIndexArray++;
                }
                arrayLength--;

                if (transpositionIndexArray == 0) isNeedSorting = false;

            } while (isNeedSorting);
        }
    }
}
