namespace _2.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.05m;
            Console.WriteLine($"Interest for Savings Account: {interest}");
        }
    }
}

