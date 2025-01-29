namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array = Console.ReadLine().Split(' ');
            //foreach (var item in array)
            //{
            //    int[] ints = Array.ConvertAll(array, int.Parse);
            //}
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(numbers);

            int first = numbers[0];
            int last = numbers[numbers.Length - 1];
            int middle;

            if (numbers.Length % 2 == 0)
            {
                middle = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2;
            }
            else
            {
                middle = numbers[numbers.Length / 2];
            }

            int average = (first + middle + last) / 3;

            Console.WriteLine(average);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}

