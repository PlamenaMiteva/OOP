namespace Capitalism.Models.Factories
{
    using Interfaces;

    public class CompanyFactory : ICompanyFactory
    {
        public Company CreateCompany(string companyName )
        {
            var company = new Company(companyName);
            return company;
        }
    }
}
