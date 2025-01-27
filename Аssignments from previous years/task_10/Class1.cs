namespace task_10
{
    class Class1
    {
        public void SetExample()
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = { 4, 5, 6, 7, 8 };
            int[] C = { 2, 4, 8, 10, 12 };

            HashSet<int> setA = new HashSet<int>(A);
            HashSet<int> setB = new HashSet<int>(B);
            HashSet<int> setC = new HashSet<int>(C);

            setA.IntersectWith(setB);
            setA.IntersectWith(setC);

            List<int> common = new List<int>(setA);

            foreach (int item in common)
            {
                Console.Write(item + " ");
            }
        }
    }
}
