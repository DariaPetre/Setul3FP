namespace Set3_ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" v1: ");
            string line1 = Console.ReadLine();

            Console.Write(" v2: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] v1 = new string[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = tokens1[i];


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] v2 = new string[tokens2.Length];
            for (int i = 0; i < v2.Length; i++)
                v2[i] = tokens2[i];

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

        private static void Intersectie(string[] v1, string[] v2)
        {   
            List<string> list = new List<string>();
            for(int i = 0; i < v1.Length; i++)
            {
                for(int j = 0; j < v2.Length; j++)
                {
                    if (string.Equals(v1[i], v2[j]) && !list.Contains(v1[i]))
                        list.Add(v1[i]);
                }
            }

            foreach (string s in list) Console.Write($"{s} ");
        }
        private static void Reuniune(string[] v1, string[] v2)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < v1.Length; i++)
            {
                if (!list.Contains(v1[i]))
                    list.Add(v1[i]);
            }

            for (int i = 0; i < v2.Length; i++)
            {
                if (!list.Contains(v2[i]))
                    list.Add(v2[i]);
            }
           
            foreach (string s in list) Console.Write($"{s} ");
        }
        private static void v1MINUSv2(string[] v1, string[] v2)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (string.Equals(v1[i], v2[j]) && !list.Contains(v1[i]))
                        list.Add(v1[i]);
                }
            }
            for(int i = 0; i < v1.Length; i++)
            {
                if (!list.Contains(v1[i]))
                    Console.Write($"{v1[i]} ");
            }
        }
        private static void v2Minusv1(string[] v1, string[] v2)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (string.Equals(v1[i], v2[j]) && !list.Contains(v1[i]))
                        list.Add(v1[i]);
                }
            }
            for (int i = 0; i < v2.Length; i++)
            {
                if (!list.Contains(v2[i]))
                 Console.Write($"{v2[i]} ");
            }

        }

    }
}