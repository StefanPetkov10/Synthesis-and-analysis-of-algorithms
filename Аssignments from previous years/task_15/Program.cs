namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int middleMainDiagonal = GetMiddleDiagonalElement(A, N, true);
            int middleSecondaryDiagonal = GetMiddleDiagonalElement(A, N, false);

            Console.WriteLine($"{middleMainDiagonal}");
            Console.WriteLine($"{middleSecondaryDiagonal}");
        }

        static int GetMiddleDiagonalElement(int[,] matrix, int N, bool isMainDiagonal)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                int value = isMainDiagonal ? matrix[i, i] : matrix[i, N - i - 1];

                if (value < min)
                {
                    min = value;
                }

                if (value > max)
                {
                    max = value;
                }
            }

            return (min + max) / 2;
        }
    }
}
