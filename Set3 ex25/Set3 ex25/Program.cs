namespace Set3_ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("v1-sir strict crescator: ");
            string line1 = Console.ReadLine();

            Console.Write("v2-sir strict crescator: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int k = 0; k < v1.Length; k++)
                v1[k] = Convert.ToInt32(tokens1[k]);


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v2 = new int[tokens2.Length];
            for (int k = 0; k < v2.Length; k++)
                v2[k] = Convert.ToInt32(tokens2[k]);

            int[] v = new int[v2.Length + v1.Length];

            int i = 0, j = 0;
            int poz = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v[poz] = v1[i];
                    poz++;
                    i++;
                }
                else if (v1[i] > v2[j])
                {
                    v[poz] = v2[j];
                    poz++;
                    j++;
                }
                else
                {
                    v[poz] = v1[i];
                    i++;
                    j++;
                    poz++;
                }
            }

            if (i == v1.Length)
            {
                for (int k = j; k < v2.Length; k++)
                {
                    v[poz] = v2[k];
                    poz++;
                }
            }
            else if (j == v2.Length)
            {
                for (int k = i; k < v1.Length; k++)
                {
                    v[poz] = v1[k];
                    poz++;
                }
            }
            
            for(int k = 0; k < poz; k++)
                Console.Write($"{v[k]} ");
        }
    }
}