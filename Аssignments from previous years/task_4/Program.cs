namespace task_4
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 60, 48, 120, 36 };

            // Finding the GCD manually
            int gcd = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                gcd = FindGCD(gcd, numbers[i]);
            }

            // Sorting the array manually (Bubble Sort)
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"The GCD of the array is: {gcd}");
            Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
        }

        static int FindGCD(int a, int b)
        {
            //алгоритъм на Евклид.
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
