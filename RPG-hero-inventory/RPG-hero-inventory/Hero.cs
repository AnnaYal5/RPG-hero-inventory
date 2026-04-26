namespace RPG_hero_inventory;
public class Hero
{
    public int HP { get; set; }
    public int MaxHP { get; set; }

    public int Attack { get; set; }
    public int Defense { get; set; }
    public string Name { get; set; }
    public Inventory<Item> Inventory { get; set; }
    public Hero(string name, int maxHp, int attack, int defense, decimal maxWeight)    
    {
        HP = MaxHP;
        Attack = attack;
        Defense = defense;
        Name = name;
        MaxHP = maxHp;
        Inventory = new Inventory<Item>(maxWeight);
    }
}