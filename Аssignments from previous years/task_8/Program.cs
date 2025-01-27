namespace task_8
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[,] A = {
            { 3, 5, 8, 2 },
            { 1, 6, 4, 9 },
            { 7, 2, 3, 5 },
            { 1, 8, 6, 4 }
        };

            int[] rowSums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += A[i, j];
                }
                rowSums[i] = rowSum;
            }

            for (int i = 0; i < rowSums.Length - 1; i++)
            {
                for (int j = 0; j < rowSums.Length - i - 1; j++)
                {
                    if (rowSums[j] > rowSums[j + 1])
                    {
                        int temp = rowSums[j];
                        rowSums[j] = rowSums[j + 1];
                        rowSums[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < rowSums.Length; i++)
            {
                Console.Write(rowSums[i] + " ");
            }
        }
    }
}
