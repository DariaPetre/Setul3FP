
namespace Set3_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= n)
                throw new Exception("Vectorul nu are elemente al caror index sa fie egal cu k.");

            int[] v = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            for(int i = k; i < n-1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}