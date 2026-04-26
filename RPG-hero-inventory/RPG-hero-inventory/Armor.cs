namespace RPG_hero_inventory;

public class Armor: Item
{
    public int DefenseBonus { get; set; }

    public Armor(string name, decimal weight, Rarity rarity, int defenseBonus) 
        : base(name, weight, rarity)
    {
        DefenseBonus = defenseBonus;
    }

    public override void Use(Hero hero)
    {
        hero.Defense += DefenseBonus;
        Console.WriteLine($"{Name} - {DefenseBonus}");
    }
    public override string ToString()
    {
        return $"[{Rarity}] {Name} (вага: {Weight}, захист: +{DefenseBonus})";
    }
    
}