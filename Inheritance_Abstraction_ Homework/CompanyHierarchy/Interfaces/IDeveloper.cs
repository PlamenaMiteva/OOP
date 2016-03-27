namespace CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using CompanyHierarchy.Models;

    public interface IDeveloper
    {
        IEnumerable<Project> Projects { get;}
    }
}
