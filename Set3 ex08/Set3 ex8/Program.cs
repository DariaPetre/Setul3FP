namespace Set3_ex8
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

            int aux = v[0];

            for(int i = 0; i < n - 1; i++) 
            {
                v[i] = v[i + 1];
            }

            v[n-1] = aux;

            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
                
        }
    }
}