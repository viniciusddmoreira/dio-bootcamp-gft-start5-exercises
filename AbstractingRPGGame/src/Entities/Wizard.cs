namespace AbstractingRPGGame.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int maxHP, int maxMP, int currentHP, int currentMP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            MaxHP = maxHP;
            MaxMP = maxMP;
            CurrentHP = currentHP;
            CurrentMP = currentMP;

        }
        public Wizard()
        {

        }
        public override string Attack()
        {
            return Name + " realizou um ataque mágico";
        }
        public override string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " realizou um ataque mágico super efetivo com bonus de " + bonus;
            }
            else
            {
                return Name + " realizou um ataque mágico com bonus de " + bonus;
            }
        }
    }
}