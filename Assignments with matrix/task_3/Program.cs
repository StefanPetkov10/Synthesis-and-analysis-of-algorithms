
namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Enter the size N of the square matrices (N > 0): ");
                n = int.Parse(Console.ReadLine() ?? "0");
            }
            while (n <= 0);

            int[,] matrix = new int[n, n];

            Console.WriteLine("\nEnter elements for matrix A:");
            InputMatrix(matrix);

            Console.WriteLine("\nMatrix A:");
            PrintMatrix(matrix);

            int[] array = ExtractDigitsBetweenInterval(matrix);

            Console.WriteLine("\nArray C (before sorting):");
            Console.WriteLine(string.Join(", ", array));

            Array.Sort(array);
            Console.WriteLine(string.Join(", ", array));
        }

        private static int[] ExtractDigitsBetweenInterval(int[,] matrix)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter range: ");
            int range1 = int.Parse(Console.ReadLine() ?? "0");
            int range2 = int.Parse(Console.ReadLine() ?? "0");

            if (range1 == range2)
            {
                range2 = int.Parse(Console.ReadLine() ?? "0");
            }

            if (range1 > range2)
            {
                int temp = range1;
                range1 = range2;
                range2 = temp;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= range1 && matrix[i, j] <= range2)
                    {
                        list.Add(matrix[i, j]);
                    }
                }
            }

            return list.ToArray();
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }

        private static void InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value = 0;

                    do
                    {
                        Console.Write($"matrix[{i + 1}, {j + 1}] (range -100 to 100) = ");
                        value = int.Parse(Console.ReadLine() ?? "0");
                    } while (value < -100 || value > 100);

                    matrix[i, j] = value;
                }
            }
        }
    }
}
