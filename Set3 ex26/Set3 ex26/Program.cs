using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Set3_ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Introduceti cifrele numarului separate prin spatiu: ");
            string line1 = Console.ReadLine();

            Console.WriteLine("Introduceti cifrele numarului separate prin spatiu: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);

            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v2 = new int[tokens2.Length];
            for (int i = 0; i < v2.Length; i++)
                v2[i] = Convert.ToInt32(tokens2[i]);

            int[] v = new int[v1.Length+v2.Length];

            Console.Write("Suma este: ");
            Suma(v1, v2, v);
            bool ok = false;
            for (int i = 0; i < v1.Length + v2.Length; i++)
            {
                if(v[i] != 0)
                    ok = true;
                if(ok)
                  Console.Write(v[i]);
            }

            for (int i = 0; i < v1.Length + v2.Length; i++)
            {
                v[i] = 0;
            }

            Console.WriteLine();
            Console.Write("Diferenta este: ");
            Deferenta(v1, v2, v);  // v1 > v2
            ok = false;
            for (int i = 0; i <= v1.Length; i++)
            {
                if (v[i] != 0)
                    ok = true;
                if (ok)
                    Console.Write(v[i]);
            }
            for (int i = 0; i < v1.Length + v2.Length; i++)
            {
                v[i] = 0;
            }

            /*Console.WriteLine();
            Console.Write("Produsul este: ");
            Produs(v1, v2, v);
            ok = false;
            for (int i = 0; i < v1.Length + v2.Length; i++)
            {
                if (v[i] != 0)
                    ok = true;
                if (ok)
                    Console.Write(v[i]);
            }
            */

        }

      

        private static int[] Produs(int[] v1, int[] v2, int[] v)
        {
            
            return v;
        }

        private static int[] Deferenta(int[] v1, int[] v2, int[] v)
        {   
            int pozV =v1.Length;
            int i = v1.Length - 1;
            int j = v2.Length - 1;

            int imprumut = 0;
            while (i >= 0 && j >= 0)
            {
                v[pozV] = v1[i--] - v2[j--] - imprumut;

                if (v[pozV] < 0)
                {
                    v[pozV] += 10;
                    imprumut = 1;
                }
                else
                    imprumut = 0;
                pozV--;
            }
            if(i >= 0)
                v[pozV--] = v1[i--] - imprumut;
            for (int k = i; k >= 0; k--)
                v[pozV--] = v1[k]; 
                return v;
        }

        private static int[] Suma(int[] v1, int[] v2, int[] v)
        {
            int pozV = v1.Length + v2.Length - 1;
            int surplus = 0;
            for (int i = Math.Min(v1.Length, v2.Length) -1; i >= 0; i--)
            {   
                if(v1.Length < v2.Length)
                {
                    int poz = i + Math.Abs(v1.Length - v2.Length);
                    v[pozV] = (v1[i] + v2[poz] + surplus) % 10;
                    if (v1[i] + v2[poz] + surplus > 9)
                        surplus = 1;
                    else surplus = 0;
                }
                else
                {
                    int poz = i + Math.Abs(v1.Length - v2.Length);
                    v[pozV] = (v1[poz] + v2[i] + surplus) % 10;
                    if (v1[poz] + v2[i] + surplus  > 9)
                        surplus = 1;
                    else surplus = 0;
                }
                pozV--;
            }
            if(v1.Length > v2.Length)
            {
                for(int i = v1.Length - v2.Length - 1; i >= 0; i--)
                {
                    v[pozV] = (v1[i] + surplus) %10;
                    if (v1[i] + surplus > 9)
                        surplus = 1;
                    else surplus = 0;
                    pozV--;
                }
            }
            else if(v1.Length < v2.Length)
            {
                for (int i = v2.Length - v1.Length - 1; i >= 0; i--)
                {
                    v[pozV] = (v2[i] + surplus) % 10;
                    if (v2[i] + surplus > 9)
                        surplus = 1;
                    else surplus = 0;
                    pozV--;
                }
            }
            v[pozV] = v[pozV] + surplus;
            return v;
        }
    }
}