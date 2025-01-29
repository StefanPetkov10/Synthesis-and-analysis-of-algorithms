namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] A = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }

            ProcessMatrix(A, n);
        }

        static void ProcessMatrix(double[,] A, int n)
        {
            double SP = 0, SO = 0, SD1 = 0, SD2 = 0;
            int SN = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double value = A[i, j];

                    if (value > 0)
                        SP += value;
                    else if (value < 0)
                        SO += value;
                    else
                        SN++;

                    if (i == j)
                        SD1 += value;
                    if (i + j == n - 1)
                        SD2 += value;
                }
            }

            Console.WriteLine($"SP = {SP}");
            Console.WriteLine($"SO = {SO}");
            Console.WriteLine($"SD1 = {SD1}");
            Console.WriteLine($"SD2 = {SD2}");
            Console.WriteLine($"SN = {SN}");
        }
    }
}








