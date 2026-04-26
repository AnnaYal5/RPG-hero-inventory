namespace RPG_hero_inventory;

public abstract class Item: IComparable<Item>
{
    public string Name { get; set; }
    public decimal Weight { get; set; }
    public Rarity Rarity { get; set; }

    public Item(string name, decimal weight, Rarity rarity)
    {
        Name = name;
        Weight = weight;
        Rarity = rarity;
    }

    public abstract void Use(Hero hero);

    public int CompareTo(Item other)
    {
        if (other == null) return 1;
        return Rarity.CompareTo(other.Rarity);
    }
    public override string ToString()
    {
        return $"[{Rarity}] {Name} (вага: {Weight})";
    }
}