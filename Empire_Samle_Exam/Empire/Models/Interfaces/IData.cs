namespace Empire.Models.Interfaces
{
    using System.Collections.Generic;
    using Empire.Models.Enums;

    public interface IData
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resources { get; }
    }
}
