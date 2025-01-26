namespace task_1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Task: Working with two 2D arrays A[N, N] and B[N, N] and creating a 1D array C[N].");
            Console.WriteLine("Author: Stefan Petkov\n");

            int n;
            do
            {
                Console.Write("Enter the size N of the square matrices (N > 0): ");
                n = int.Parse(Console.ReadLine() ?? "0");
            }
            while (n <= 0);

            int[,] A = new int[n, n];
            int[,] B = new int[n, n];

            Console.WriteLine("\nEnter elements for matrix A:");
            InputMatrix(A);
            Console.WriteLine("\nEnter elements for matrix B:");
            InputMatrix(B);

            Console.WriteLine("\nMatrix A:");
            PrintMatrix(A);
            Console.WriteLine("\nMatrix B:");
            PrintMatrix(B);

            int[] C = new int[n];
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i, i] + B[i, i];
            }

            Console.WriteLine("\nArray C (before sorting):");
            Console.WriteLine(string.Join(", ", C));

            Array.Sort(C);

            Console.WriteLine("\nArray C (after sorting):");
            Console.WriteLine(string.Join(", ", C));
        }

        static void InputMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value;
                    do
                    {
                        Console.Write($"matrix[{i + 1}, {j + 1}] (range -100 to 100) = ");
                        value = int.Parse(Console.ReadLine()!);
                    } while (value < -100 || value > 100);
                    matrix[i, j] = value;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(6));
                }
                Console.WriteLine();
            }
        }
    }
}
