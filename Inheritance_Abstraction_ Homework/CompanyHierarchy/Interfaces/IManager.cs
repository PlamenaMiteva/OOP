namespace CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using CompanyHierarchy.Models;

    public interface IManager
    {
        IEnumerable<Employee> Subordinates { get; }
    }
}
