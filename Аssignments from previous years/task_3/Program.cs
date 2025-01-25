namespace task_3
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 50, 102, 150, 9999, 10000, 200, 3050, 75 };
            int count = 0;

            foreach (int number in numbers)
            {
                if (number > 100 && number < 10000 && number % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"The count of even numbers greater than 100 and less than 10,000 is: {count}");
        }
    }
}
