using firstdotsix;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Solution solution = new Solution();

        Console.WriteLine(solution.Method(n, x));
    }
}