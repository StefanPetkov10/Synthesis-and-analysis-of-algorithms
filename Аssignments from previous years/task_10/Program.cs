namespace task_10
{
    public class Program
    {
        public static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 2, 3, 6, 7 };
            int[] array3 = { 1, 3, 4, 8 };

            var commonValues = FindCommonValues(array1, array2, array3);

            Console.WriteLine("United equal values:");
            foreach (var value in commonValues)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Set Example:");
            var class1Instance = new Class1();
            class1Instance.SetExample();
        }

        public static List<int> FindCommonValues(int[] array1, int[] array2, int[] array3)
        {
            var valueCount = new Dictionary<int, int>();
            var commonValues = new List<int>();

            foreach (var value in array1)
            {
                if (!valueCount.ContainsKey(value))
                    valueCount[value] = 1;
            }

            foreach (var value in array2)
            {
                if (valueCount.ContainsKey(value) && valueCount[value] == 1)
                    valueCount[value] = 2;
            }

            foreach (var value in array3)
            {
                if (valueCount.ContainsKey(value) && valueCount[value] == 2)
                {
                    commonValues.Add(value);
                }
            }

            return commonValues;
        }
    }
}


