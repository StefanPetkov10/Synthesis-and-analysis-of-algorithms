namespace Cocktail_Shaker_Sort
{
    class CocktailSortExample
    {
        static void CocktailSort(int[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length - 1;

            while (swapped)
            {
                swapped = false;

                for (int i = start; i < end; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;

                end--;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                start++;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 4, 2, 8, 0, 2 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", numbers));

            CocktailSort(numbers);

            Console.WriteLine("\nAfter sorting:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }

}
