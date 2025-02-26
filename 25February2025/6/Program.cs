namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split(' ').ToArray();
            Array.Sort(sentence);

            Console.WriteLine("Ordered sentence : ");
            foreach(string word in sentence)
            {
                Console.Write(word + " ");
            }
        }
    }
}
