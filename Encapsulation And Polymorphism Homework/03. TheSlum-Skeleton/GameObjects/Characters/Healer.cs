using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.GameObjects.Characters
{
    public class Healer: AdvancedCharachter, IHeal
    {
        private const int DefaultHealingPoints = 60;
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultRange = 6;


        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .Where(t => t.Id != this.Id && t.Team == this.Team && t.IsAlive == true)
                .OrderBy(t => t.HealthPoints)
                .FirstOrDefault();
        }

        public int HealingPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Healing Points: " + this.HealingPoints;
        }
    }
}
