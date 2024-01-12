namespace Set3_ex31
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

            int contor = 0, candidat = -1;
            for (int i = 0; i < n; i++)
            {
         
                if (contor == 0)
                {
                    candidat = v[i];
                    contor = 1;
                }
                else
                {
                    if (v[i] == candidat)
                        contor += 1;
                    else
                        contor -= 1;
                }
            }

            int aparitii = 0;
            for (int i = 0; i < n; i++)
                if (v[i] == candidat)
                    aparitii += 1;


            if (aparitii < n / 2 + 1)
                Console.WriteLine("Vectorul nu are element majoritar.");
            else
                Console.WriteLine($"Elementul majoritar etse {candidat}, iar nr de aparitii este {aparitii}.");
        }
    }
}