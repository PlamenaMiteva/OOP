namespace Empire.Models.Core
{
    using System;
    using System.Collections.Generic;
    using Empire.Models.Enums;
    using Empire.Models.Interfaces;

    public class Data : IData
    {
        private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        
        public Data()
        {
           this.Resources = new Dictionary<ResourceType, int>();
           this.Units = new Dictionary<string, int>();
           this.InitResources();
        }

        private void InitResources()
        {
            foreach (ResourceType resourceType in Enum.GetValues(typeof(ResourceType)))
            {
                this.Resources.Add(resourceType, 0);
            }
        }

        public IEnumerable<IBuilding> Buildings {get { return this.buildings; }}
        

        public void AddBuilding(IBuilding building)
        {
            if (building==null)
            {
                throw new ArgumentNullException("building");
            }
            this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit==null)
            {
                throw new ArgumentNullException("unit");
            }
            var unitType = unit.GetType().Name;
            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }
            this.Units[unitType]++;
        }

        public IDictionary<ResourceType, int> Resources { get; protected set; }

        public IDictionary<string, int> Units { get; protected set; }
    }
}
