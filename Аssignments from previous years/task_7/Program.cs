namespace task_7
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[,] A = {
            { 3, -5, 8, 2 },
            { -1, 6, 4, 9 },
            { 7, -2, -3, 5 },
            { 1, 8, -6, 4 }
        };

            int[] B = new int[n + 2];
            int diagonalSum = 0;
            int negativeCount = 0;

            for (int i = 0; i < n; i++)
            {
                int minRowValue = A[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (A[i, j] < minRowValue)
                    {
                        minRowValue = A[i, j];
                    }
                }
                B[i] = minRowValue;

                diagonalSum += A[i, i];

                if (A[i, n - i - 1] < 0)
                {
                    negativeCount++;
                }
            }

            B[n] = diagonalSum;
            B[n + 1] = negativeCount;

            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - i - 1; j++)
                {
                    if (B[j] > B[j + 1])
                    {
                        int temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
        }
    }
}
