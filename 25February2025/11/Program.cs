namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int> { 45, 78, 32, 90, 50, 67, 49, 80, 20 };
            grades = grades.Select(grade => grade < 50 ? 50 : grade).ToList();
            Console.WriteLine(string.Join(", ", grades));
        }
    }
}