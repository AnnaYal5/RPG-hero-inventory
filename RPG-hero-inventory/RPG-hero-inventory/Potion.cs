namespace RPG_hero_inventory;

public class Potion: Item
{
    public int HealAmount { get; set; }

    public Potion(string name, decimal weight, Rarity rarity, int healAmount) : base(name, weight, rarity)
    {
        HealAmount = healAmount;
    }

    public override void Use(Hero hero)
    {
        hero.HP += HealAmount;
        Console.WriteLine($"{Name} - {HealAmount}");
    }
}