namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 15 && n >= 1)
            {
                int[,] A = new int[n, n];
                int[] B = new int[n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int value = int.Parse(Console.ReadLine());
                        if (value < -20 || value > 20)
                        {
                            Console.WriteLine("Invalid input.");
                            return;
                        }
                        A[i, j] = value;
                    }
                }

                ProcessMatrix(A, B, n);

                Console.WriteLine("Sorted array B:");
                foreach (var value in B)
                {
                    Console.Write(value + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid size.");
            }
        }

        static void ProcessMatrix(int[,] A, int[] B, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > 0)
                    {
                        sum += A[i, j];
                    }
                }

                B[i] = sum;
            }

            CountingSort(B, n);
        }

        static void CountingSort(int[] B, int n)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (B[i] > max)
                {
                    max = B[i];
                }
            }

            int[] count = new int[max + 1];

            for (int i = 0; i < n; i++)
            {
                count[B[i]]++;
            }

            int index = 0;
            for (int i = max; i >= 0; i--)
            {
                while (count[i] > 0)
                {
                    B[index] = i;
                    index++;
                    count[i]--;
                }
            }
        }
    }
}