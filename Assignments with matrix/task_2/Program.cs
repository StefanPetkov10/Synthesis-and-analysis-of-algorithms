namespace task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the size N of the square matrices (N > 0): ");
            do
            {
                n = int.Parse(Console.ReadLine()!);
            }
            while (n <= 0);

            int[,] A = new int[n, n];

            Console.WriteLine("\nEnter elements for matrix A:");
            InputMatrix(A);

            Console.WriteLine("\nMatrix A:");
            PrintMatrix(A);

            int[] C = ExtractSquare(A);

            Console.WriteLine("\nArray C (before sorting):");
            Console.WriteLine(string.Join(", ", C));

            BubbleSort(C);
            Console.WriteLine(string.Join(", ", C));
        }

        private static void BubbleSort(int[] c)
        {
            for (int i = 0; i < c.Length - 1; i++)
            {
                for (int j = 0; j < c.Length - i - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        int temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void InputMatrix(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value;
                    do
                    {
                        Console.WriteLine("Enter digit between -10 and 10");
                        value = int.Parse(Console.ReadLine()!);
                    }
                    while (value < -10 && value > 10);

                    a[i, j] = value;
                }
            }
        }

        private static int[] ExtractSquare(int[,] matrix)
        {
            List<int> result = new();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] * matrix[i, j] > 50)
                    {
                        result.Add(matrix[i, j]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
