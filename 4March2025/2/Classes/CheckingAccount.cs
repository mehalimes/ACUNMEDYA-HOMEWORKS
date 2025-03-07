namespace _2.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }
}
