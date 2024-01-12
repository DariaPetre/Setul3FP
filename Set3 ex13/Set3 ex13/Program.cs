namespace Set3_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                int x = v[i];
                int p = i - 1;
                while (p >= 0 && v[p] > x)
                {
                    v[p + 1] = v[p];
                    p--;
                }
                v[p + 1] = x;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i]);
                Console.Write(" ");
            }
        }
    }
}