namespace Capitalism.Models
{
    using Capitalism.Enums;
    
    public class RegularEmployee : Employee
    {
        private Department department;

        public RegularEmployee(string firstName, string lastName, Position position, Company company, Department department) 
            : base(firstName, lastName, position, company)
        {
            this.Department = department;
        }

        public Department Department { get; set; }
    }
}
