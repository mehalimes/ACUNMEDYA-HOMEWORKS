namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Mehmet", "Ali", "Meşe", "Muhammed", "İnan", "Engin", "Demiroğ" };

            int mx = -1;
            int mn = int.MaxValue;
            string mxString = "";
            string mnString = "";

            foreach(string word in words)
            {
                if(word.Length > mx)
                {
                    mx = word.Length;
                    mxString = word;
                }
                if(word.Length < mn)
                {
                    mn = word.Length;
                    mnString = word;
                }
            }

            Console.WriteLine($"Longest : {mxString}");
            Console.WriteLine($"Shortest : {mnString}");
        }
    }
}
