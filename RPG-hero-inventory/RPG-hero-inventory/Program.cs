namespace RPG_hero_inventory;

public class Program
{
    static void Main()
    {
        var hero = new Hero(10, 5, 2);
        var inventory = new Inventory<Item>(10);

        var sword = new Weapon("Sword", 3, Rarity.Common, 5);
        var armor = new Armor("Shield", 2, Rarity.Epic, 8);
        var potion = new Potion("Potion", 1, Rarity.Common, 10);

        inventory.Add(sword);
        inventory.Add(armor);
        inventory.Add(potion);

        foreach (var item in inventory)
        {
            item.Use(hero);
        }

        inventory.SortByRarity();

        Console.WriteLine("Після сортування:");
        foreach (var item in inventory)
        {
            Console.WriteLine(item.Name + " - " + item.Rarity);
        }
    }
}