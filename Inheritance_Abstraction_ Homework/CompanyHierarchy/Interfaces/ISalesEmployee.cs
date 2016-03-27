namespace CompanyHierarchy.Interfaces
{
    using Models;

    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        IEnumerable<Sale> Sales { get;}
    }
}
