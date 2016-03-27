namespace Capitalism.Models.Factories
{
    using System;
    using Capitalism.Enums;
    using Capitalism.Interfaces;

    public class EmployeeFactory: IEmployeeFactory
    {
        public IEmployee CreateEmployee(string firstName, string lastName, Position position, Company company, Department department)
        {
            var employee = new RegularEmployee(firstName, lastName, position, company, department);
            return employee;
        }
    }
}
