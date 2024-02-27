namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, - 11, 35, - 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                int swapVar = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swapVar)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
    
}
