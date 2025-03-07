using _1.Classes;

namespace _1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "Ahmet Yılmaz", 5000, "Yönetim", 10);
            Developer developer = new Developer(2, "Mehmet Ali Meşe", 3000, "Yazılım", "Frontend Developer");

            Console.WriteLine($"Yönetici {manager.Name} maaşının %20'si kadar bonus alacak: {manager.CalculateBonus()}");
            Console.WriteLine($"Geliştirici {developer.Name} maaşının %10'u kadar bonus alacak: {developer.CalculateBonus()}");
        }
    }
}
