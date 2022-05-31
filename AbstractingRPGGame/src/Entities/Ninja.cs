namespace AbstractingRPGGame.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int maxHP, int maxMP, int currentHP, int currentMP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            MaxHP = maxHP;
            MaxMP = maxMP;
            CurrentHP = currentHP;
            CurrentMP = currentMP;

        }
        public Ninja()
        {

        }
    }
}