namespace Set3_ex7
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
                Console.Write($"Introduceti numarul de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= (n-1) / 2; i++)
            {
                (v[i], v[n - i - 1]) = (v[n - i - 1], v[i]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}