namespace RPG_hero_inventory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Inventory<T> : IEnumerable<T> where T : Item
{
    private List<T> _items = new List<T>();
    private decimal _MaxWeight;

    public Inventory(decimal maxWeight)
    {
        _MaxWeight = maxWeight;
    }
    private decimal CurrentWeight => _items.Sum(i => i.Weight);

    public void Add(T item)
    {
        if (CurrentWeight + item.Weight <= _MaxWeight)
        { 
            _items.Add(item);
        }
        else
        {
            Console.WriteLine($"вагу перевищено");
        }
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public T GetByName(string name)
    {
        return _items.FirstOrDefault(i => i.Name == name);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void SortByRarity()
    {
        _items.Sort();
    }
}