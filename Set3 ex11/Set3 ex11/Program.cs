namespace Set3_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int[] ciur = new int[n+1];

            for(int i = 2; i <= n; i++)
            {
                if (ciur[i] == 0)
                {
                    for(int j = 2 * i; j <= n; j+=i)
                        ciur[j] = 1;
                }
            }
            if (n == 1)
                Console.WriteLine();
            else
            {
                for(int i = 2; i <= n; i++)
                {
                    if (ciur[i] == 0)
                        Console.Write($"{i} ");
                }
            }
        }
    }
}