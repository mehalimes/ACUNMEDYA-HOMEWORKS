namespace _1.Classes
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
        public Manager(int id, string name, double salary, string department, int teamSize)
            : base(id, name, salary, department)
        {
            TeamSize = teamSize;
        }
    }
}
