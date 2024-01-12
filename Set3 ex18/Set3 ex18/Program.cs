namespace Set3_ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gradul polinomului este: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Punctul in care se calculeaza valoarera polinomului este: ");
            int x = int.Parse(Console.ReadLine());

            int[] v = new int[n+1];

            int P = 0;
            for(int i = 0; i <= n; i++) 
            {
                Console.Write($"Introduceti coeficientul lui x^{i}: ");
                v[i] = int.Parse(Console.ReadLine());
                P += v[i] * (int)Math.Pow(x, i);
            }

            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {P}.");
        }
    }
}