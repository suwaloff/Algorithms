namespace Algorithms.Search
{

    /// <summary>
    ///     A Jump search algorithm implementation
    /// </summary>
    public class JumpSearch
    {
        public static int Search(int[] array, int key)
        {
            int jump = (int)Math.Sqrt(array.Length);
            int step = 0;

            while (array[Math.Min(jump, array.Length) - 1] < key)
            {
                step = jump;
                jump += (int)Math.Sqrt(array.Length);

                if (step >= array.Length)
                {
                    return -1;
                }
            }

            while (array[step] <= key)
            {
                if (array[step] == key)
                {
                    return key;
                }
                step++;
            }
            return -1;
           
        }

    }
}
