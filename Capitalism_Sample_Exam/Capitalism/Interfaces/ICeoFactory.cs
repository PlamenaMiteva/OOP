using Capitalism.Models;

namespace Capitalism.Interfaces
{
    public interface ICeoFactory
    {
        IEmployee CreateCeo(string firstName, string lastName, Company company, decimal salary);
    }
}
