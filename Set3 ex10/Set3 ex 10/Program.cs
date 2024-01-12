namespace Set3_ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti elementele de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            int poz = -1;

            int st = 0;
            int dr = n - 1;

            while (st <= dr && poz == -1)
            {
                int mij = (st + dr) / 2;
                if (v[mij] == k)
                {
                    poz = mij;
                }
                else if (v[mij] < k)
                    st = mij + 1;
                else 
                    dr = mij - 1;
            }
            Console.WriteLine(poz);
        }
    }
}
