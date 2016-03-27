namespace Empire.Models.Core.Units
{
    public class Swordsman :Unit
    {
        private const int SwordsmanAttackDemage = 13;
        private const int SwordsmanAttackHealth = 40;

        public Swordsman() :
            base(SwordsmanAttackDemage, SwordsmanAttackHealth)
        {
        }
    }
}
