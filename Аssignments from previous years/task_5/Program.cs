namespace task_5
{
    class Program
    {
        static void Main()
        {
            int[] A = { 60, 45, 18, 17, 99, 36 };
            int maxEven = -1;
            int minOdd = int.MaxValue;

            foreach (int number in A)
            {
                if (number % 2 == 0 && number > maxEven)
                {
                    maxEven = number;
                }
                else if (number % 2 != 0 && number < minOdd)
                {
                    minOdd = number;
                }
            }

            if (maxEven != -1 && minOdd != int.MaxValue)
            {
                int gcd = FindGCD(maxEven, minOdd);
                Console.WriteLine($"GCD of {maxEven} and {minOdd} is: {gcd}");
            }
            else
            {
                Console.WriteLine("No valid even and/or odd elements found.");
            }
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
