namespace LatihanOverloadingMethod
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine($"Minimum #1: {number.FindMinimum(5, 125)}");
            Console.WriteLine($"Minimum #2: {number.FindMinimum(70, 128, 22)}");
            Console.WriteLine();
            Console.WriteLine($"Maximum #1: {number.FindMaximum(6, 120)}");
            Console.WriteLine($"Maximum #2: {number.FindMaximum(70, 800, 92)}");
        }
    }
}