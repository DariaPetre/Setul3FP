
namespace Set3_ex16
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

            int cmmdc = v[0];

            for(int i = 1; i < n; i++) 
            {
                while (v[i] != 0)
                {
                    int r = cmmdc % v[i];
                    cmmdc = v[i];
                    v[i] = r;
                }
            }

            Console.WriteLine($"cmmdc = {cmmdc}");


        }
    }
}