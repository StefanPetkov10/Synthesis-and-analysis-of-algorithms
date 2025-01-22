namespace Bubble_Sort
{
    class BubbleSortExample
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Before sort:");
            Console.WriteLine(string.Join(", ", numbers));

            BubbleSort(numbers);

            Console.WriteLine("\nAfter sort:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
