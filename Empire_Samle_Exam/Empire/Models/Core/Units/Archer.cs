namespace Empire.Models.Core.Units
{
    public class Archer : Unit
    {
        private const int ArcherAttackDemage = 7;
        private const int ArcherAttackHealth = 25;
        public Archer() :base(ArcherAttackDemage, ArcherAttackHealth)
        {
        }
    }
}
