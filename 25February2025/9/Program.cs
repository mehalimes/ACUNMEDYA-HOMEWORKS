namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number count : "); int count = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            for(int i = 0; i < count; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("Average : " + numbers.Average());
            Console.Write("Sorted List : ");
            numbers.Sort();
            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
