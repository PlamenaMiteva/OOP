namespace Capitalism.Models.Factories
{
    using Capitalism.Interfaces;

    public class CeoFactory : ICeoFactory
    {
        public IEmployee CreateCeo(string firstName, string lastName, Company company, decimal salary)
        {
            var manager = new CEO(firstName, lastName, company, salary);
            return manager;
        }
    }
}
