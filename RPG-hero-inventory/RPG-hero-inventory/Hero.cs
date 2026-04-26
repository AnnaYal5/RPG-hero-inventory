namespace RPG_hero_inventory;
public class Hero
{
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Hero(int hp, int attack, int defense)
    {
        HP = hp;
        Attack = attack;
        Defense = defense;
    }
}