using System;
using Empire.Models.Enums;
using Empire.Models.Interfaces;

namespace Empire.Models.Core
{
    public class Resource: IResource 
    {
        private int quantity;

        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; private set; }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Resource quantity cannot be negative.");
                }

                this.quantity = value;
            }
        }
    }
}
