namespace Merge_Sort
{
    class MergeSortExample
    {
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[middle + 1 + j];

            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    arr[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                arr[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                arr[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", numbers));

            MergeSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("\nAfter sorting:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
