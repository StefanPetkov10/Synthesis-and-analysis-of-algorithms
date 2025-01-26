namespace task_4
{
    using System;

    class Program
    {
        static void Main()
        {
            const int k = 3;
            const int l = 3;
            float[,] A = new float[k, l];
            float[,] B = new float[k, l];
            float M, N, Q;

            Console.WriteLine("Uslovie na zadacha 3:");
            Console.WriteLine("Danni na avtor:");


            Console.WriteLine($"Vavedete elementite na masiva A[{k}][{l}]:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write($"A[{i}][{j}]: ");
                    A[i, j] = float.Parse(Console.ReadLine());

                    while (!(-999.99 > A[i, j]) || !(A[i, j] > 999.999))
                    {
                        Console.WriteLine("Greshka, vavedete otnovo:");
                        A[i, j] = float.Parse(Console.ReadLine());
                    }
                }
            }

            // Otpechatvane na vhodni danni
            Console.WriteLine("Izvejdane na vhodni danni:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write($" {A[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            Console.Write("Vavedete minimalna granica za interval: ");
            M = float.Parse(Console.ReadLine());
            Console.Write("Vavedete maksimalna granica za intervala: ");
            N = float.Parse(Console.ReadLine());
            Console.Write("Vavedete chislo, s koeto shte zamenite otricatelnite chisla: ");
            Q = float.Parse(Console.ReadLine());

            int broiElementi = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (A[i, j] >= M && A[i, j] <= N && A[i, j] < 0)
                    {
                        A[i, j] = Q;
                        broiElementi++;
                    }
                    B[i, j] = A[i, j];
                }
            }

            Console.WriteLine($"Broi promeneni chisla: {broiElementi}");
            Console.WriteLine("Novata matrica:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write($"{B[i, j]:F3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
