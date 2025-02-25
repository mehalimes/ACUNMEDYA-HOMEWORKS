namespace _3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<byte> ages = new List<byte> { 10, 20, 11, 14, 13, 19, 54, 64 , 65, 100};

            foreach(byte age in ages)
            {
                if (age >= 0 && age <= 12)
                    Console.WriteLine($"Child {age}");
                else if (age >= 13 && age <= 19)
                    Console.WriteLine($"Teenage {age}");
                else if (age >= 20 && age <= 64)
                    Console.WriteLine($"Adult {age}");
                else if (age >= 65)
                    Console.WriteLine($"Old {age}");
            }
        }
    }
}
