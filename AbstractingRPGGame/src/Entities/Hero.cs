namespace AbstractingRPGGame.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }
        public int CurrentHP { get; set; }
        public int CurrentMP { get; set; }

        public Hero(string name, int level, string heroType, int maxHP, int maxMP, int currentHP, int currentMP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            MaxHP = maxHP;
            MaxMP = maxMP;
            CurrentHP = currentHP;
            CurrentMP = currentMP;

        }
        public Hero()
        {

        }
        public override string ToString()
        {
            return "Name: " + Name + " Lv.: " + Level + " Class: " + HeroType + " HP: " + CurrentHP + "/" + MaxHP + " SP: " + CurrentMP + "/" + MaxMP;
        }

        public virtual string Attack()
        {
            return Name + " realizou um ataque físico.";
        }

        public virtual string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " realizou um ataque físico super efetivo com bonus de " + bonus;
            }
            else
            {
                return Name + " realizou um ataque físico com bonus de " + bonus;
            }

        }

    }
}