namespace Set2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine()) ;
            }

            int max = v.Max();
            int min = v.Min();
            Console.WriteLine($"Max = {max}, min={min}");
        }
    }
}
