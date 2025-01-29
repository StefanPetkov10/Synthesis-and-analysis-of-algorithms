namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, -3, 4, 7, -2, 8 };
            int[] B = { 2, 5, 4, 9, 6, 10 };

            int[] C = CreateArray(A, B);

            Console.WriteLine("Array C (sorted descending):");
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write(C[i] + " ");
            }
        }

        static int[] CreateArray(int[] A, int[] B)
        {
            int size = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0) size++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] % 2 == 0) size++;
            }

            int[] C = new int[size];
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    C[index] = A[i];
                    index++;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] % 2 == 0)
                {
                    C[index] = B[i];
                    index++;
                }
            }

            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        int temp = C[j];
                        C[j] = C[j + 1];
                        C[j + 1] = temp;
                    }
                }
            }

            return C;
        }
    }
}
