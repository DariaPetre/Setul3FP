
namespace Set3_ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti pe o linie elementele vectorului v1: ");
            string line1 = Console.ReadLine();

            Console.Write("Introduceti pe o linie elementele vectorului v2: ");
            string line2 = Console.ReadLine();

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] v1 = new string[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = tokens1[i];


            string[] tokens2 = line2.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] v2 = new string[tokens2.Length];
            for (int i = 0; i < v2.Length; i++)
                v2[i] = tokens2[i];

            for(int i = 0; i < v1.Length; i++)
                v1[i] = v1[i].ToLower();

            for (int i = 0; i < v2.Length; i++)
                v2[i] = v2[i].ToLower();

            bool v1AparePrimul = false;
            bool v2AparePrimul = false;
            bool suntEgale = true;
            for(int i = 0; i < Math.Min(v1.Length,v2.Length); i++)
            {
                for(int j = 0; j < Math.Min(v1[i].Length, v2[i].Length); j++)
                {
                    if (v1[i][j] > v2[i][j])
                    {
                        v2AparePrimul = true;
                        suntEgale = false;
                        break;
                    }
                    else if(v1[i][j] < v2[i][j])
                    {
                        v1AparePrimul = true;
                        suntEgale = false;
                        break;
                    }


                }
                if (suntEgale)
                {
                    if (v1[i].Length > v2[i].Length)
                    {
                        v2AparePrimul = true;
                        suntEgale = false;
                        break;
                    }
                    else if (v1[i].Length < v2[i].Length)
                    {
                        v1AparePrimul = true;
                        suntEgale = false;
                        break;
                    }
                }
                else
                    break;

            }
            if (suntEgale)
            {
                if (v1.Length > v2.Length)
                {
                    v2AparePrimul = true;
                    suntEgale = false;
                }
                else if (v1.Length < v2.Length)
                {
                    v1AparePrimul = true;
                    suntEgale = false;
                }
            }

            if (v1AparePrimul)
                Console.WriteLine("v1 apare primul in dictionar.");
            else if(v2AparePrimul)
                Console.WriteLine("v2 apare primul in dictionar.");
            else
                Console.WriteLine("Vectorii sunt egali.");
        }
    }
}