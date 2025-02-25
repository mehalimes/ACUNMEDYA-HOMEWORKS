namespace _2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number < 10 || number > 100)
            {
                Console.Write("Enter a number again : ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Your number is valid {number}");
        }
    }
}
