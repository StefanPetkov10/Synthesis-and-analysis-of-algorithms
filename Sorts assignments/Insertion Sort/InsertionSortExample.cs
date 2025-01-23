namespace Insertion_Sort
{
    class InsertionSortExample
    {
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 12, 11, 13, 5, 6 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", numbers));

            InsertionSort(numbers);

            Console.WriteLine("\nAfter sorting:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }

}
