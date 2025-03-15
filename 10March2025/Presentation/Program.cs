using Businness;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var languageManager = new ProgrammingLanguageManager();
            var technologyManager = new TechnologyManager();

            while (true)
            {
                Console.WriteLine("1. Programlama Dili Ekle");
                Console.WriteLine("2. Teknoloji Ekle");
                Console.WriteLine("3. Programlama Dillerini Listele");
                Console.WriteLine("4. Teknolojileri Listele");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Programlama Dili Adı: ");
                        string langName = Console.ReadLine();
                        languageManager.AddLanguage(langName);
                        break;
                    case "2":
                        Console.Write("Teknoloji Adı: ");
                        string techName = Console.ReadLine();
                        Console.Write("Programlama Dili ID: ");
                        int langId = int.Parse(Console.ReadLine());
                        technologyManager.AddTechnology(techName, langId);
                        break;
                    case "3":
                        foreach (var lang in languageManager.GetAllLanguages())
                            Console.WriteLine($"ID: {lang.Id}, Name: {lang.Name}");
                        break;
                    case "4":
                        foreach (var tech in technologyManager.GetAllTechnologies())
                            Console.WriteLine($"ID: {tech.Id}, Name: {tech.Name}, LanguageID: {tech.ProgrammingLanguageId}");
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}
