using System.Text;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Frigate : Starship
    {

        //private int projectilesFired;

        public Frigate(string name, StarSystem location, int health = 60, int shields = 50, int damage = 30, double fuel = 220)
            : base(name, health, shields, damage, fuel, location)
        {
        }

        public int ProjectilesFired { get; set; }

        public override IProjectile ProduceAttack()
        {
            this.ProjectilesFired++;
            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            if (this.Health > 0)
            {
                output.Append(string.Format("-Projectiles fired: {0}", this.ProjectilesFired));
            }
            return output.ToString();
        }
    }
}
