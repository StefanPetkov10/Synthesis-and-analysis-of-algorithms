namespace task_6
{
    class Program
    {
        static void Main()
        {
            int[] A = { 60, 45, 18, 17, 99 };
            int[] B = { 55, 50, 20, 18, 95 };
            int n = A.Length;
            int[] C = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > B[i])
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i];
                }
                sum += C[i];
            }

            if (sum >= 100 && sum <= 999)
            {
                int lastDigit = sum;
                while (lastDigit >= 10)
                {
                    lastDigit = lastDigit % 10;
                }
                int lastDigit2 = sum % 10;
                Console.WriteLine("Last digit of sum: " + lastDigit + lastDigit2);
            }
        }
    }
}
