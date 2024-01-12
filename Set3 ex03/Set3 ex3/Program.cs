namespace Set3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            int pMin = 0;
            int pMax = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}:");
                v[i] = int.Parse(Console.ReadLine());
            }

            if ((n & 1) == 0)
            {
                if (v[0] < v[1])
                {
                    pMin = 0;
                    pMax = 1;
                }
                else
                {
                    pMin = 1;
                    pMax = 0;
                }
            }
            

            int pm=0, pM=0;

            if((n & 1) ==0) 
            {
                for(int i = 2;i < n; i+=2) 
                {
                    if (v[i] < v[i+1]) 
                    {
                        pm = i;
                        pM = i+1;
                    }
                    else
                    {
                        pm = i+1;
                        pM = i;
                    }

                    if(v[pm] < v[pMin])
                        pMin = pm;
                    if (v[pM] > v[pMax])
                        pMax = pM;
                }
            }
            else
            {
                for(int i = 1;i < n; i+=2)
                {
                    if (v[i] < v[i + 1])
                    {
                        pm = i;
                        pM = i + 1;
                    }
                    else
                    {
                        pm = i + 1;
                        pM = i;
                    }

                    if (v[pm] < v[pMin])
                        pMin = pm;
                    if (v[pM] > v[pMax])
                        pMax = pM;
                }
            }
            Console.WriteLine($"Pozitia pe care se afla cel mai mic nr este {pMin}.");
            Console.WriteLine($"Pozitia pe care se afla cel mai mare nr este {pMax}.");

        }
    }
}