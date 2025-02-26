namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine().Split(' ').ToList();
            sentence.Reverse();
            Console.Write("Reversed sentence : ");
            foreach(string word in sentence)
            {
                Console.Write(word + " ");
            }
        }
    }
}
