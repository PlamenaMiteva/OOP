namespace Empire.Models.Core.Buildings
{
    using System;
    using Empire.Models.Enums;
    using Empire.Models.Interfaces;

    //public delegate void UnitProducedEventHandler(object sender, UnitProducedEventArgs e);
    //public delegate void ResourceProducedEventHandler(object sender, ResourceProducedEventArgs e);

    public abstract class Building : IBuilding
    {
        //public event UnitProducedEventHandler OnUnitProduced;
        //public event ResourceProducedEventHandler OnResourceProduced;

        private int cycleCount = -1;
        private readonly string unitType;
        private int unitCycleLength;
        private readonly ResourceType resourceType;
        private int resourceCycleLength;
        private int resourceQuantity;
        private readonly IUnitFactory unitFactory;
        private readonly IResourceFactory resourceFactory;

        protected Building(
            string unitType,
            int unitCycleLength,
            int resourceQuantity,
            ResourceType resourceType,
            int resourceCycleLength,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.UnitCycleLength = unitCycleLength;
            this.resourceType = resourceType;
            this.ResourceCycleLength = resourceCycleLength;
            this.ResourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }
        private int UnitCycleLength
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The length of the production cycle for units should be positive.");
                }

                this.unitCycleLength = value;
            }
        }

        private int ResourceCycleLength
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The length of the production cycle for units should be positive.");
                }

                this.resourceCycleLength = value;
            }
        }

        private int ResourceQuantity
        {
            get { return this.resourceQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The resource quantity produced by the building cannot be negative.");
                }

                this.resourceQuantity = value;
            }
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cycleCount > 0 && this.cycleCount % this.unitCycleLength == 0;
                return canProduceUnit;
            }
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource = this.cycleCount > 0 && this.cycleCount % this.resourceCycleLength == 0;
                return canProduceResource;
            }
        }

        public void Update()
        {
            this.cycleCount++;
            //if (CanProduceUnit)
            //{
            //    if (this.OnUnitProduced != null)
            //    {
            //        var unit = this.unitFactory.CreateUnit(this.unitType);
            //        this.OnUnitProduced(this, new UnitProducedEventArgs{Unit = unit});
            //    }
            //}
            //if (CanProduceResource)
            //{
            //    if (this.OnResourceProduced != null)
            //    {
            //        var resource = this.resourceFactory.CreateResource(this.resourceType, this.ResourceQuantity);
            //        this.OnResourceProduced(this, new ResourceProducedEventArgs{Resource = resource});
            //    }
            //}
        }

        public IResource ProduceResource()
        {
            var resource = this.resourceFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }
        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }

        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLength - (this.cycleCount % this.unitCycleLength);
            int turnsUntilResource = this.resourceCycleLength - (this.cycleCount % this.resourceCycleLength);


            var result = string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.cycleCount,
                turnsUntilUnit,
                this.unitType,
                turnsUntilResource,
                this.resourceType);
            return result;
        }
    }
}
