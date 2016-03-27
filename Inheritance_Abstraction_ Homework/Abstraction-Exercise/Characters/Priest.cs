namespace Abstraction_Exercise.Characters
{
    using Abstraction_Exercise.Interfaces;

    public class Priest:Character, IHeal
    {
        public Priest() : base(125, 200, 100)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Demage;
            this.Health += this.Demage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
