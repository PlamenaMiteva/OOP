namespace Empire.Models.Core.Buildings
{
    using Empire.Models.Enums;
    using Empire.Models.Interfaces;

    public class Barracks : Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCycleLength = 4;
        private const int BarracksResourceQuantity = 10;
        private const ResourceType BarracksResourceType = Enums.ResourceType.Steel;
        private const int BarracksResourceCycleLength = 3;

        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory) :
            base(BarracksUnitType, BarracksUnitCycleLength, BarracksResourceQuantity, BarracksResourceType,
            BarracksResourceCycleLength, unitFactory, resourceFactory)
        {
        }
    }
}
