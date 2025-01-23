namespace Shell_Sort
{
    class ShellSortExample
    {
        static void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 12, 34, 54, 2, 3 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", numbers));

            ShellSort(numbers);

            Console.WriteLine("\nAfter sorting:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
