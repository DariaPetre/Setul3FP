namespace Set3_ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1=");
            int n1 = int.Parse(Console.ReadLine());

            int[] s = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Introduceti elementul de pe pozitia {i} din vectorul s: ");
                s[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("n2=");
            int n2 = int.Parse(Console.ReadLine());

            int[] p = new int[n1];

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Introduceti elementul de pe pozitia {i} din vectorul p: ");
                p[i] = int.Parse(Console.ReadLine());
            }

            int cnt = 0;
            for(int i = 0; i <= n1-n2; i++)
            {
                bool egale = true;
                for(int j = 0; j < n2; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        egale = false;
                        break;
                    }
                }

                if (egale)
                    cnt++;
            }

            Console.WriteLine($"Vectorul p apare de {cnt} ori in s.");
          
        }
    }
}