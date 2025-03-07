using _2.Classes;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount()
            {
                AccountHolder = "Mehmet Ali Meşe",
                Balance = 1000m
            };

            BankAccount account2 = new SavingsAccount()
            {
                AccountHolder = "Muhammed İnan",
                Balance = 1500m
            };

            BankAccount account3 = new CheckingAccount()
            {
                AccountHolder = "Engin Demiroğ",
                Balance = 2000m
            };

            Console.WriteLine($"{account1.AccountHolder}'s Account:");
            account1.CalculateInterest();

            Console.WriteLine($"{account2.AccountHolder}'s Account:");
            account2.CalculateInterest();

            Console.WriteLine($"{account3.AccountHolder}'s Account:");
            account3.CalculateInterest();

            Console.ReadLine();
        }
    }

}
