using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace _02.Customer.Models
{
    public class Customer : ICloneable
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string PermanentAddress { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public Customer(string firstName, string middleName, string lastname, string email, string mobiile, string address, string id, CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastname;
            this.Email = email;
            this.Mobile = mobiile;
            this.PermanentAddress = address;
            this.Id = id;
            this.CustomerType = type;
        }

        public CustomerType CustomerType { get; set; }

        public ICollection<Payment> Payments { get; set; }


        public object Clone()
        {
            Customer newCustomer = (Customer)this.MemberwiseClone();
            ICollection<Payment> NewPayments = Payments.Select(payment => (Payment) payment.Clone()).ToList();
            newCustomer.Payments = NewPayments;

            return newCustomer;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Customer customer = obj as Customer;
            if ((System.Object)customer == null)
            {
                return false;
            }
            return (FirstName == customer.FirstName) && 
                   (MiddleName == customer.MiddleName) && 
                   (LastName == customer.LastName) &&
                   (Email == customer.Email) &&
                   (PermanentAddress == customer.PermanentAddress) &&
                   (Mobile == customer.Mobile) &&
                   (Id == customer.Id) &&
                   (CustomerType == customer.CustomerType) &&
                   (Payments.SequenceEqual(customer.Payments));
        }


        public bool Equals(Customer customer)
        {
            if ((object)customer == null)
            {
                return false;
            } 
            return (FirstName == customer.FirstName) &&
                    (MiddleName == customer.MiddleName) &&
                    (LastName == customer.LastName) &&
                    (Email == customer.Email) &&
                    (PermanentAddress == customer.PermanentAddress) &&
                    (Mobile == customer.Mobile) &&
                    (Id == customer.Id) &&
                    (CustomerType == customer.CustomerType) &&
                    (Payments.SequenceEqual(customer.Payments));
        }


        public static bool operator ==(Customer a, Customer b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            return (a.FirstName == b.FirstName) &&
                    (a.MiddleName == b.MiddleName) &&
                    (a.LastName == b.LastName) &&
                    (a.Email == b.Email) &&
                    (a.PermanentAddress == b.PermanentAddress) &&
                    (a.Mobile == b.Mobile) &&
                    (a.Id == b.Id) &&
                    (a.CustomerType == b.CustomerType) &&
                    (a.Payments.SequenceEqual(b.Payments));
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashHelper.GetHashCode
                (this.FirstName, this.MiddleName, this.LastName, this.Email, 
                this.Mobile, this.PermanentAddress, this.CustomerType, this.Id)+
                HashHelper.GetListHashCode(this.Payments);
            
        }
        
    }
}
