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
        

        int oldHp = hero.HP;
        hero.HP = Math.Min(hero.HP + HealAmount, hero.MaxHP);
        Console.WriteLine($"{hero.Name} випив {Name}. HP: {oldHp} → {hero.HP}");

    }
    public override string ToString()
    {
        return $"[{Rarity}] {Name} (вага: {Weight}, +{HealAmount} HP)";
    }
}