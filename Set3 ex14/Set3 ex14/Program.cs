namespace Set3_ex14
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

            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                {
                    if (v[k] != 0)
                    {
                        (v[i], v[k]) = (v[k], v[i]);
                        k--;
                    }
                    else
                    {
                        while (v[k] == 0 && k > i)
                            k--;

                        if(v[k] != 0 && k > i)
                            (v[i], v[k]) = (v[k], v[i]);
                    }
                }
            }

            for(int i = 0;i < n;i++)
                Console.Write($"{v[i]} ");

        }
    }
}