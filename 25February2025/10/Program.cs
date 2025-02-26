namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 11, 6, 4, 9, 20, 30, 90, 100 };
            numbers.RemoveAll(number => number < 10);
            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}