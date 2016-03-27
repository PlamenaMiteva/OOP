using System;
using System.Linq;

namespace CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using System.Text;
    using CompanyHierarchy.Interfaces;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string fname, string lname, decimal salary, Department department)
            : base(id, fname, lname, salary, department)
        {
            this.sales = new List<Sale>();
        }

        public IEnumerable<Sale> Sales
        {
            get { return this.sales; }
        }

        public void AddSale(Sale sale)
        {
            if (sale==null)
            {
                throw  new ArgumentNullException("Sale cannot be null.");
            }
            if (sale.Price < 0)
            {
                throw new ArgumentOutOfRangeException("Sale cannot have a negative price.");
            }
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Department + " Department - " + this.Id + " - " + this.FirstName + " " + this.LastName + " - " + this.Salary + " BGN" + System.Environment.NewLine);
            if (this.Sales.Any())
            {
                result.Append("Sales:" + System.Environment.NewLine);
                foreach (var sale in this.Sales)
                {
                    result.Append(sale.ProductName + " - " + sale.SaleDate + " - " + sale.Price + " BGN" + System.Environment.NewLine);
                }
            }
            else
            {
                result.Append("No Sales");
            }
            return result.ToString();
        }
    }
}
