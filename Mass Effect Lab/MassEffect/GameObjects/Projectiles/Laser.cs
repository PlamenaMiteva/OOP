using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser: Projectile
    {
        public Laser(int damage) : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            if (this.Damage > targetShip.Shields)
            {
                targetShip.Health -= this.Damage - targetShip.Shields;
                targetShip.Shields = 0;
            }
            else
            {
                targetShip.Shields -= this.Damage;
            }
        }
    }
}
