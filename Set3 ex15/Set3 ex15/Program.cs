namespace Set3_ex15
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

            for(int i = 0; i < n; i++) 
            {
                for(int j = i+1; j < n; j++)
                {
                    if(v[j] == v[i])
                    {
                        for (int k = j; k < n-1; k++)
                            v[k] = v[k + 1];
                        n--;
                        j--;
                    }
                }
            }

            for(int i = 0; i < n; i++) 
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}