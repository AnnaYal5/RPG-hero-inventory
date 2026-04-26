namespace RPG_hero_inventory;

public class Program
{
    static void Main()
    {
        var hero = new Hero("Name1", 100,10, 5, 20);
        var items = new List<Item>
        {
            new Weapon("Меч Дракона", 3.5m, Rarity.Legendary, 25),
            new Armor("Щит Стражника", 5m, Rarity.Rare, 15),
            new Potion("Зілля лікування", 0.5m, Rarity.Common, 30)
        };

        while (true)
        {
            Console.WriteLine("1. Показати інвентор");
            Console.WriteLine("2. Додати предмет");
            Console.WriteLine("3. Використати предмет");
            Console.WriteLine("4. Сортувати за рідкістю");
            Console.WriteLine("5. Показати героя");
            Console.WriteLine("6. Вихід");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowInventory(hero);
                    break;
                case "2":
                    AddItem(hero, items);                   
                    break;
                case "3":
                    UseItem(hero);
                    break;
                case "4":
                    hero.Inventory.SortByRarity();
                    Console.WriteLine("Відсортовано!");
                    break;
                case "5":
                    ShowHero(hero);
                    break;
                case "6":
                    return;
            }
        }
    }
    static void ShowInventory(Hero hero)

    {
        Console.WriteLine($"{hero.Name}");
        int i = 1;
        foreach (var item in hero.Inventory)
        {
            Console.WriteLine($"{i++}. {item}");
        }
        Console.WriteLine($"Вага: {hero.Inventory.CurrentWeight}");
    }

    static void AddItem(Hero hero, List<Item> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            choice--;
            if (choice >= 0 && choice < items.Count)
                hero.Inventory.Add(items[choice]);
        }
    }

    static void UseItem(Hero hero)
    {
        Console.Write("Введіть назву предмета: ");
        string name = Console.ReadLine();
        var item = hero.Inventory.GetByName(name);
        if (item == null) return;
        item.Use(hero);
        if (item is Potion)
            hero.Inventory.Remove(item);
    }

    static void ShowHero(Hero hero)
    {
        Console.WriteLine($"{hero.Name}: HP={hero.HP}/{hero.MaxHP}, ATK={hero.Attack}, DEF={hero.Defense}");
    }
}