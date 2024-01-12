namespace Set3_ex29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("v1: ");
            string line1 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);

            MergeSort(v1, 0, v1.Length - 1);

            for (int i = 0; i < v1.Length; i++)
                Console.Write($"{v1[i]} ");
        }

        private static void MergeSort(int[] v, int st, int dr)
        {
            int[] a = new int[v.Length+1];
                if (st < dr)
                {
                    int m = (st + dr) / 2;
                    MergeSort(v, st, m);
                    MergeSort(v, m + 1, dr);
                    
                    int i = st, j = m + 1, k = 0;
                    while (i <= m && j <= dr)
                        if (v[i] < v[j])
                            a[++k] = v[i++];
                        else
                            a[++k] = v[j++];
                    while (i <= m)
                        a[++k] = v[i++];
                    while (j <= dr)
                        a[++k] = v[j++];
                    for (i = st, j = 1; i <= dr; i++, j++)
                        v[i] = a[j];
                }
            
        }
    }
}