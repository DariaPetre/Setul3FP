namespace Set3_ex28
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Console.Write("v1: ");
            string line1 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);

            QuickSort(v1);

            for(int i = 0; i < v1.Length; i++)
                Console.Write($"{v1[i]} ");
            
        }
        private static int Partition(int[] v, int st, int dr)
        {
            int k = st;
            for (int i = st + 1; i <= dr; i++)
                if (v[i] < v[st])
                {
                    k++;
                    (v[i], v[k]) = (v[k], v[i]);
                }
            (v[st], v[k]) = (v[k], v[st]);
            return k;
        }
        private static void QuickSort(int[] v)
        {
            QuickSortHelper(v, 0, v.Length - 1);
        }

        private static void QuickSortHelper(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int idx = r.Next(st, dr + 1);
                (v[st], v[idx]) = (v[idx], v[st]);
                int k = Partition(v, st, dr);

                QuickSortHelper(v, st, k - 1);
                QuickSortHelper(v, k + 1, dr);
            }
        }
    }
}