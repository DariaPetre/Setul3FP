namespace Set3_ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" v1-sir strict crescator: ");
            string line1 = Console.ReadLine();

            Console.Write(" v2-sir strict crescator: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v2 = new int[tokens2.Length];
            for (int i = 0; i < v2.Length; i++)
                v2[i] = Convert.ToInt32(tokens2[i]);

            Console.Write(" v1 intersectat cu v2: ");
            Intersectie(v1, v2);
            Console.WriteLine();

            Console.Write(" v1 reunit cu v2: ");
            Reuniune(v1, v2);
            Console.WriteLine();

            Console.Write(" v1 - v2: ");
            v1MINUSv2(v1, v2);
            Console.WriteLine();

            Console.Write(" v2 - v1: ");
            v2Minusv1(v1, v2);
            Console.WriteLine();
        }


        private static void Intersectie(int[] v1, int[] v2)
        {
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])  i++;
                else if (v1[i] > v2[j])  j++;
                else
                {
                    Console.Write($"{v1[i]} ");
                    i++;
                    j++;
                }
            }

        }
    
        private static void Reuniune(int[] v1, int[] v2)
        {
            int i=0, j=0;
            while(i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    Console.Write($"{v1[i]} ");
                    i++;
                }
                else if(v1[i] > v2[j])
                {
                    Console.Write($"{v2[j]} ");
                    j++;
                }
                else
                {
                    Console.Write($"{v1[i]} ");
                    i++;
                    j++;
                }
            }

            if (i == v1.Length)
            {
                for (int k = j; k < v2.Length; k++)
                    Console.Write($"{v2[k]} ");
            }
            else if (j == v2.Length)
            {
                for (int k = i; k < v1.Length; k++)
                    Console.Write($"{v1[k]} ");
            }
        }
        private static void v1MINUSv2(int[] v1, int[] v2)
        {
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    Console.Write($"{v1[i]} ");
                    i++;
                }
                else if (v1[i] > v2[j])   j++;
                else
                {
                    i++;
                    j++;
                }
            }

            if (j == v2.Length)
            {
                for (int k = i; k < v1.Length; k++)
                    Console.Write($"{v1[k]} ");
            }
        }
        private static void v2Minusv1(int[] v1, int[] v2)
        {
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])   i++;
                else if (v1[i] > v2[j])
                {
                    Console.Write($"{v2[i]} ");
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            if (i == v1.Length)
            {
                for (int k = j; k < v2.Length; k++)
                    Console.Write($"{v2[k]} ");
            }
        }
    }
}