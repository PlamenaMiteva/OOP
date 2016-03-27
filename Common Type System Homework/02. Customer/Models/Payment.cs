using System;

namespace _02.Customer.Models
{
    public class Payment : ICloneable
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
