namespace TheSlum.GameObjects.Items
{
    public class Injection : Bonus
    {
        private const int HealthEffectDefault = 200;
        private const int DefenseEffectDefault = 0;
        private const int AttackEffectDefault = 0;
        private const int TimeOutTurns = 3;


        public Injection(string id)
            : base(id, HealthEffectDefault, DefenseEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeOutTurns;
            this.Countdown = TimeOutTurns;
        }
    }
}
