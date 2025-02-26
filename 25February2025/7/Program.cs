namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            Console.WriteLine("Current size : " + array.Length);

            Console.Write("Enter size : "); int size = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref array, size);

            Console.WriteLine("New size : " + array.Length);
        }
    }
}
