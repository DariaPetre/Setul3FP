namespace Set3_ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("v1-sir strict crescator(v[i] este 1 daca i face parte din multime si este 0 in caz contrar): ");
            string line1 = Console.ReadLine();

            Console.WriteLine("v2-sir strict crescator(v[i] este 1 daca i face parte din multime si este 0 in caz contrar): ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v2 = new int[tokens2.Length];
            for (int i = 0; i < v2.Length; i++)
                v2[i] = Convert.ToInt32(tokens2[i]);

            Console.Write("v1 intersectat cu v2: ");
            Intersectie(v1, v2);
            Console.WriteLine();

            Console.Write("v1 reunit cu v2: ");
            Reuniune(v1, v2);
            Console.WriteLine();

            Console.Write("v1 - v2: ");
            v1MINUSv2(v1, v2);
            Console.WriteLine();

            Console.Write("v2 - v1: ");
            v2Minusv1(v1, v2);
            Console.WriteLine();
        }


        private static void Intersectie(int[] v1, int[] v2)
        {
            for(int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
            {
                if (v1[i] == 1 && v2[i] == 1)
                    Console.Write($"{i} ");
            }

        }

        private static void Reuniune(int[] v1, int[] v2)
        {
            for (int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
            {
                if (v1[i] == 1 || v2[i] == 1)
                    Console.Write($"{i} ");
            }

            if(v1.Length < v2.Length)
            {
                for (int i = v1.Length; i < v2.Length; i++)
                {
                    if (v2[i] == 1)
                        Console.Write($"{i} ");
                }
            }
            else if (v1.Length > v2.Length)
            {
                for (int i = v2.Length; i < v1.Length; i++)
                {
                    if (v1[i] == 1)
                        Console.Write($"{i} ");
                }
            }

        }
            
        private static void v1MINUSv2(int[] v1, int[] v2)
        {
            for (int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
            {
                if (v1[i] == 1 && v2[i] == 0)
                    Console.Write($"{i} ");
            }

            if (v1.Length > v2.Length)
            {
                for (int i = v2.Length; i < v1.Length; i++)
                {
                    if (v1[i] == 1)
                        Console.Write($"{i} ");
                }
            }
        }
        private static void v2Minusv1(int[] v1, int[] v2)
        {
            for (int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
            {
                if (v1[i] == 0 && v2[i] == 1)
                    Console.Write($"{i} ");
            }

            if (v1.Length < v2.Length)
            {
                for (int i = v1.Length; i < v2.Length; i++)
                {
                    if (v2[i] == 1)
                        Console.Write($"{i} ");
                }
            }
        }
        
    }
}