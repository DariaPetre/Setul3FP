
namespace Set3_ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            string n = Console.ReadLine();

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (b <= 1 || b >= 17)
                throw new Exception("numarul b trebuie sa fie din intervalul [2,16]");

            decimal nr = decimal.Parse(n);
            int ParteInt = (int)Math.Truncate(nr);
            Console.WriteLine(ParteInt);
            decimal ParteFract = nr - ParteInt;

            Console.Write($"Numarul {n} convertit in baza {b} este: ");
            conversieInt(ParteInt, b);

            if(ParteFract > 0)
            {
                Console.Write(".");
                conversieFract(ParteFract,b);
            }

        }

        static void conversieInt(int  parteInt, int b)
        {
            if (parteInt > 0)
            {
                conversieInt(parteInt / b, b);
                Console.Write(parteInt % b);
            }
        }

        private static void conversieFract(decimal parteFract, int b)
        {
            List<decimal> fractii = new List<decimal>();
            List<decimal> cifre = new List<decimal>();

            fractii.Add(parteFract);
            bool periodica = false;
            while (parteFract != 0)
            {
                parteFract = parteFract * b;
                cifre.Add(Math.Truncate(parteFract));
                parteFract = parteFract - Math.Truncate(parteFract);

                if (!fractii.Contains(parteFract))
                {
                    fractii.Add(parteFract);
                }
                else
                {
                    periodica = true;
                    break;
                }

            }
            if (!periodica)
            {
                foreach (var item in cifre)
                    Console.Write(item);
            }
            else
            {
                for (int i = 0; i < fractii.Count; i++)
                {
                    if (fractii[i] == parteFract)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
       

    }
}