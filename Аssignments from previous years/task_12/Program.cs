namespace task_12
{
    public class Program
    {
        public static void Main()
        {
            int[,] matrix = {
            { 4, 7, 2, 1 },
            { 6, 5, 8, 3 },
            { 1, 9, 3, 4 },
            { 2, 0, 6, 8 }
            };

            List<int> list = new List<int>();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"Row {i + 1} average: {rowSum / cols}");
            }

            for (int j = 0; j < cols; j++)
            {
                double colSum = 0;
                for (int i = 0; i < rows; i++)
                {
                    colSum += matrix[i, j];
                }
                Console.WriteLine($"Column {j + 1} average: {colSum / rows}");
            }

            double mainDiagonalSum = 0;
            int positiveMainDiagonal = 0, negativeMainDiagonal = 0;
            for (int i = 0; i < rows; i++)
            {
                mainDiagonalSum += matrix[i, i];
                list.Add(matrix[i, i]);
                if (matrix[i, i] > 0) positiveMainDiagonal++;
                if (matrix[i, i] < 0) negativeMainDiagonal++;
            }
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine($"Main diagonal average: {mainDiagonalSum / rows}");
            Console.WriteLine($"Positive in main diagonal: {positiveMainDiagonal}");
            Console.WriteLine($"Negative in main diagonal: {negativeMainDiagonal}");

            double secondaryDiagonalSum = 0;
            int positiveSecondaryDiagonal = 0, negativeSecondaryDiagonal = 0;
            for (int i = 0; i < rows; i++)
            {
                secondaryDiagonalSum += matrix[i, cols - i - 1];
                if (matrix[i, cols - i - 1] > 0) positiveSecondaryDiagonal++;
                if (matrix[i, cols - i - 1] < 0) negativeSecondaryDiagonal++;
            }
            Console.WriteLine($"Secondary diagonal average: {secondaryDiagonalSum / rows}");
            Console.WriteLine($"Positive in secondary diagonal: {positiveSecondaryDiagonal}");
            Console.WriteLine($"Negative in secondary diagonal: {negativeSecondaryDiagonal}");

            Console.WriteLine("Elements below the main diagonal:");
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine("\nElements above the secondary diagonal:");
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = cols - i; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}
