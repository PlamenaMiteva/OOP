namespace CompanyHierarchy.Models
{
    public class RegularEmployee:Employee
    {
        public RegularEmployee(int id, string fname, string lname, decimal salary, Department department) 
            : base(id, fname, lname, salary, department)
        {
        }
    }
}
