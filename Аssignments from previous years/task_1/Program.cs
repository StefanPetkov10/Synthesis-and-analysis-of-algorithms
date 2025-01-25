namespace task_1
{
    class Program
    {
        static void Main()
        {
            int[] A = GenerateUniqueArray(10);
            int[] B = GenerateUniqueArray(15);
            int[] C = GenerateUniqueArray(20);

            Console.WriteLine("Масив A: " + string.Join(", ", A));
            Console.WriteLine("Масив B: " + string.Join(", ", B));
            Console.WriteLine("Масив C: " + string.Join(", ", C));

            var commonElements = FindCommonElements(A, B, C);

            Console.WriteLine("Common elements: " + (commonElements.Any() ? string.Join(", ", commonElements) : "There are no common elements"));
        }

        static int[] GenerateUniqueArray(int size)
        {
            Random random = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < size)
            {
                uniqueNumbers.Add(random.Next(1, 101));
            }

            return uniqueNumbers.ToArray();
        }

        static List<int> FindCommonElements(int[] A, int[] B, int[] C)
        {
            bool[] freqA = new bool[101];
            bool[] freqB = new bool[101];
            bool[] freqC = new bool[101];

            foreach (int x in A)
                freqA[x] = true;

            foreach (int x in B)
                freqB[x] = true;

            foreach (int x in C)
                freqC[x] = true;

            List<int> commonElements = new List<int>();
            for (int x = 1; x <= 100; x++)
            {
                if (freqA[x] && freqB[x] && freqC[x])
                {
                    commonElements.Add(x);
                }
            }

            return commonElements;
        }
    }
}
