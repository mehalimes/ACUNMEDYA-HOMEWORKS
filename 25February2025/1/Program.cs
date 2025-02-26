namespace _1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string number = Console.ReadLine();
            int sum = 0;
            for(int i = 0; i < number.Length; i++)
            {
               
                sum += 
                    // Checking for negative numbers.
                    int.TryParse(number[i].ToString(), out _) ? Convert.ToInt32(number[i].ToString()) : 0;
            }
            Console.WriteLine($"Sum : {sum}");
        }
    }
}
