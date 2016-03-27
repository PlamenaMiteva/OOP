using Empire.Models.Enums;
using Empire.Models.Interfaces;

namespace Empire.Models.Core.Buildings
{
    public class Archery : Building
    {

        private const string ArcheryUnitType = "Archer";
        private const int ArcheryUnitCycleLength = 3;
        private const int ArcheryResourceQuantity = 5;
        private const ResourceType ArcheryResourceType = Enums.ResourceType.Gold;
        private const int ArcheryResourceCycleLength = 2;

        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(ArcheryUnitType, ArcheryUnitCycleLength, ArcheryResourceQuantity, ArcheryResourceType, 
            ArcheryResourceCycleLength, unitFactory, resourceFactory)
        {
        }
    }
}
