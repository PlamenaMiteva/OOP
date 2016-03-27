using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Cruiser:Starship
    {
        public Cruiser(string name, StarSystem location, int health=100, int shields=100, int damage=50, double fuel=300 ) 
            : base(name, health, shields, damage, fuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return  new PenetrationShell(this.Damage);
        }
    }
}
