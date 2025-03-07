namespace _1.Classes
{
    public class Developer : Employee
    {
        public string About { get; set; }
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
        public Developer(int id, string name, double salary, string department, string about)
            : base(id, name, salary, department)
        {
            About = about;
        }
    }
}
