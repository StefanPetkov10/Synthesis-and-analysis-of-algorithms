namespace task_2
{
    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Enter an odd number for the length of the array: ");
                n = int.Parse(Console.ReadLine() ?? "0");
            } while (n <= 0 || n % 2 == 0);

            int[] A = GenerateArray(n);

            Console.WriteLine("Generate array: " + string.Join(", ", A));

            CalculateS1S2(A, out double S1, out double S2);

            // Отпечатване на резултатите
            Console.WriteLine($"S1 (average of min, max и median): {S1:F2}");
            Console.WriteLine($"S2 (arithmetic mean of even positions): {S2:F2}");
        }

        static int[] GenerateArray(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 101); // Числа в диапазона [1..100]
            }
            return array;
        }

        static void CalculateS1S2(int[] A, out double S1, out double S2)
        {
            int n = A.Length;

            int[] sorted = BubbleSort(A);

            int min = A[0];
            int max = A[0];
            int median = A[0];

            int[] count = new int[101];

            for (int i = 0; i < n; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
                count[A[i]]++;
            }

            int cumulativeCount = 0;
            for (int i = 1; i <= 100; i++)
            {
                cumulativeCount += count[i];
                if (cumulativeCount >= (n / 2) + 1)
                {
                    median = i;
                    break;
                }
            }

            S1 = (min + max + median) / 3.0;

            double sumEvenPositions = 0;
            int countEvenPositions = 0;

            for (int i = 1; i < n; i += 2)
            {
                sumEvenPositions += sorted[i];
                countEvenPositions++;
            }

            S2 = sumEvenPositions / countEvenPositions;
        }

        static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
