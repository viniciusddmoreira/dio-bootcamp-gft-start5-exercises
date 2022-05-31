namespace AbstractingRPGGame.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int maxHP, int maxMP, int currentHP, int currentMP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            MaxHP = maxHP;
            MaxMP = maxMP;
            CurrentHP = currentHP;
            CurrentMP = currentMP;

        }
        public Knight()
        {

        }
    }
}