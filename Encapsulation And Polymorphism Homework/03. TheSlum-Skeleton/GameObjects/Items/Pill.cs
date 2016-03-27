namespace TheSlum.GameObjects.Items
{
    public class Pill : Bonus
    {
        private const int HealthEffectDefault = 0;
        private const int DefenseEffectDefault = 0;
        private const int AttackEffectDefault = 100;
        private const int TimeOutTurns = 1;


        public Pill(string id)
            : base(id, HealthEffectDefault, DefenseEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeOutTurns;
            this.Countdown = TimeOutTurns;
        }
    }
}
