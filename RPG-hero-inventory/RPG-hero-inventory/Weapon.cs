namespace RPG_hero_inventory;

public class Weapon: Item
{
    public int AttackBonus { get; set; }

    public Weapon(string name, decimal weight, Rarity rarity, int attackBonus) : base(name, weight, rarity)
    {
        AttackBonus = attackBonus;
    }

    public override void Use(Hero hero)
    {
        hero.Attack += AttackBonus;
        Console.WriteLine($"{Name} - {AttackBonus}");
    }
}