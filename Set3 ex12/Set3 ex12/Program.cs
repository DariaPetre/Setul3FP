namespace Set3_ex12
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

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                        (v[i], v[j]) = (v[j], v[i]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i]);
                Console.Write(" ");
            }
        }
    }
}