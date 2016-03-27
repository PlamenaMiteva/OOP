using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought:Starship
    {
        public Dreadnought(string name, StarSystem location, int health = 200, 
            int shields = 300, int damage = 150, double fuel = 700) 
            : base(name, health, shields, damage, fuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Damage + this.Shields/2);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields -= 50;
        }

        }
}
