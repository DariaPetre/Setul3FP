namespace Set3_ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("v1: ");
            string line1 = Console.ReadLine();

            Console.Write("index: ");
            int index = int.Parse(Console.ReadLine());

            string[] tokens1 = line1.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v1 = new int[tokens1.Length];
            for (int i = 0; i < v1.Length; i++)
                v1[i] = Convert.ToInt32(tokens1[i]);

            if (index < 0 || index >= v1.Length)
                throw new Exception("index is out of range of the array");

            SelectionSort(v1);
                Console.Write(v1[index]);
        }
        private static void SelectionSort(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < v.Length; j++)
                    if (v[j] < v[k])
                        k = j;
                (v[i], v[k]) = (v[k], v[i]);
            }
        }
    }
}