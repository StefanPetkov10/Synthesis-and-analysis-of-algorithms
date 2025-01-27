namespace task_9
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[,] matrix = {
            { 3, -5, 8, 2 },
            { -1, 6, 4, 9 },
            { 7, -2, -3, 5 },
            { 1, 8, -6, 4 }
        };

            int positiveCount = 0, negativeCount = 0, zeroCount = 0;
            int positiveSum = 0, negativeSum = 0;
            int mainDiagonalSum = 0, secondaryDiagonalSum = 0;
            int mainDiagonalCount = 0, secondaryDiagonalCount = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = matrix[i, j];

                    if (value > 0)
                    {
                        positiveCount++;
                        positiveSum += value;
                    }
                    else if (value < 0)
                    {
                        negativeCount++;
                        negativeSum += value;
                    }
                    else
                    {
                        zeroCount++;
                    }

                    if (i == j)
                    {
                        mainDiagonalSum += value;
                        mainDiagonalCount++;
                    }

                    if (i + j == n - 1)
                    {
                        secondaryDiagonalSum += value;
                        secondaryDiagonalCount++;
                    }
                }
            }

            double positiveAvg = positiveCount > 0 ? (double)positiveSum / positiveCount : 0;
            double negativeAvg = negativeCount > 0 ? (double)negativeSum / negativeCount : 0;
            double mainDiagonalAvg = mainDiagonalCount > 0 ? (double)mainDiagonalSum / mainDiagonalCount : 0;
            double secondaryDiagonalAvg = secondaryDiagonalCount > 0 ? (double)secondaryDiagonalSum / secondaryDiagonalCount : 0;

            Console.WriteLine($"Positive numbers count: {positiveCount}");
            Console.WriteLine($"Negative numbers count: {negativeCount}");
            Console.WriteLine($"Zero count: {zeroCount}");
            Console.WriteLine($"Average of positive numbers: {positiveAvg}");
            Console.WriteLine($"Average of negative numbers: {negativeAvg}");
            Console.WriteLine($"Average of main diagonal: {mainDiagonalAvg}");
            Console.WriteLine($"Average of secondary diagonal: {secondaryDiagonalAvg}");
        }
    }
}
