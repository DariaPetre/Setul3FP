namespace Set3_ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti siragul s1 format din A si N: ");
            string line1 = Console.ReadLine();

            Console.Write("Introduceti siragul s2 format din A si N: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s1 = new string[tokens1.Length];
            for (int i = 0; i < s1.Length; i++)
                s1[i] = tokens1[i];


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s2 = new string[tokens2.Length];
            for (int i = 0; i < s2.Length; i++)
                s2[i] = tokens2[i];

            if (s2.Length > s1.Length)
                throw new Exception("Lungimea lui s1 trebiue sa fie mai mare decat lungimea lui s2.");
            
            int nrSuprapuneri = 0;
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                bool seSuprapun = true;
                for(int j = 0; j < s2.Length; j++)
                {
                    if (s1[i+j] != s2[j])
                        seSuprapun = false;
                }
                if(seSuprapun)
                    nrSuprapuneri++;
            }

            Console.WriteLine($"Siragurile se suprapun de {nrSuprapuneri} ori.");

        }

        
    }
}