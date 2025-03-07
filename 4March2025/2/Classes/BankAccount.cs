namespace _2.Classes
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest calculation not implemented for the base class.");
        }
    }
}
