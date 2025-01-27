namespace task_11
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 12, 15, 10, 20, 30 };

            int sum = SumOfGCDs(array);

            Console.WriteLine("The sum of all greatest common divisors of adjacent pairs is: " + sum);
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int SumOfGCDs(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += GCD(array[i], array[i + 1]);
            }

            return sum;
        }
    }
}
