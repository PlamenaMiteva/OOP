namespace Capitalism.Interfaces
{   
    using Capitalism.Models;
    using Capitalism.Enums;

    public interface IEmployeeFactory
    {
        IEmployee CreateEmployee(string firstName, string lastName, Position position, Company company, Department department);
    }
}
