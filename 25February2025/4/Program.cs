namespace _4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 5, 2, 3, 1, 1, 1, 9, 8,9 };

            Dictionary<int, int> dt = new Dictionary<int, int>();

            foreach(int number in numbers)
            {
                if(dt.ContainsKey(number))
                {
                    dt[number]++;
                }
                else
                {
                    dt[number] = 1;
                }
            }

            Console.WriteLine("Repeaters");
            foreach(KeyValuePair<int, int> pair in dt)
            {
                if(pair.Value > 1)
                {
                    Console.Write(pair.Key + " ");
                }
            }

        }
    }
}
