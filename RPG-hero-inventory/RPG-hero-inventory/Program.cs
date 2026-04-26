namespace RPG_hero_inventory;

public class Program
{
    static void Main()
    {
        Hero hero = new Hero(10, 5, 2);
            
        Item sword = new Weapon("Sword", 5, Rarity.Common, 10);
        Item armor = new Armor("Shield", 2, Rarity.Epic, 8);
        Item potion = new Weapon("Health Potion", 5, Rarity.Common, 15);

        sword.Use(hero);
        armor.Use(hero);
        potion.Use(hero);
        
        Console.WriteLine($"HP: {hero.HP}, Attack: {hero.Attack}, Defense: {hero.Defense}");
    }
}