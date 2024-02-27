namespace MergingOrderedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 7, 9 };
            int[] array2 = new int[] { 2, 4, 5, 7, 8 };
            int count1 = array1.Length;
            int count2 = array2.Length;
            int[] arrayResult = new int[count1 + count2];
            int a = 0, b = 0;
            int i = 0;
            while (a < count1 && b < count2)
            {
                if (array1[a] <= array2[b])
                {
                    arrayResult[i++] = array1[a++];
                }
                else
                {
                    arrayResult[i++] = array2[b++];
                }
            }
            if (a < count1)
            {
                for (int j = a; j < count1; j++)
                {
                    arrayResult[i++] = array1[j];
                }
            }
            else
            {
                for (int j = b; j < count2; j++)
                {
                    arrayResult[i++] = array2[j];
                }
            }
            Console.WriteLine("Result is {{ {0} }}", string.Join(",", arrayResult.Select(e => e.ToString())));
        }
    }
}
