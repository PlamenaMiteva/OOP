namespace CompanyHierarchy.Models
{
    using System;

    public class Sale
    {
        private string productName;
        private DateTime saleDate;
        private decimal price;

        public Sale(string productName, DateTime saleDate, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
            this.SaleDate = saleDate;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The product name field cannot be null, empty or whitespace.");
                }
                else
                {
                    this.productName = value;
                }

            }
        }

        public DateTime? SaleDate { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }

            }
        }
    }
}
