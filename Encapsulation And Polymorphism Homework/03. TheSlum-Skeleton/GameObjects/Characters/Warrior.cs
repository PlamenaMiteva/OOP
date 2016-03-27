using System.Collections.Generic;
using System.Linq;

namespace TheSlum.GameObjects.Characters
{
    public class Warrior : AttackableCharacter
    {
        private const int DefaultAttackPoints = 150;
        private const int DefaultHealthPoints = 200;
        private const int DefaultDefensePoints = 100;
        private const int DefaultRange = 2;

        public Warrior(string id, int x, int y, Team team) 
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(c=>c.IsAlive && c.Team != this.Team);
        }
    }
}
