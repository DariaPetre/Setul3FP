namespace Set3_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());

            int poz = -1;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] == k && poz == -1)
                    poz = i;
            }
            Console.WriteLine(poz);
        }
    }
}