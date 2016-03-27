namespace Capitalism.Interfaces
{   
    using Capitalism.Models;

    public interface ICompanyFactory
    {
        Company CreateCompany(string companyName);
    }
}
