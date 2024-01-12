using System.Runtime.Intrinsics.X86;

namespace Set3_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti elementele vectorului pe o singura linie:");
            string line = Console.ReadLine();
            char[] separatori = { ' ', ',', ':' };
            string[] tokens = line.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[tokens.Length];

            int min = 2147483647;
            int max = -2147483648;

            int cntMin = 0;
            int cntMax = 0;


            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] < min)
                {
                    min = v[i];
                    cntMin = 1;
                }
                else if (v[i] == min)
                    cntMin++;

                if (v[i] > max)
                {
                    max = v[i];
                    cntMax = 1;
                }
                else if (v[i] == max)
                    cntMax++;

            }

             Console.WriteLine($"Minimul este {min}, iar nr. de aparitii este {cntMin}.");
             Console.WriteLine($"Maximul este {max}, iar nr. de aparitii este {cntMax}.");
           
        }
    }
}


