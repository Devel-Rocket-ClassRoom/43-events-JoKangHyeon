using System;
using System.Collections.Generic;

class Inventory
{
    Dictionary<string, int> _inventory;

    public event Action<string, int, int> ItemChanged;

    public Inventory()
    {
        _inventory = new();
    }

    public void AddItem(string name, int count)
    {
        int oldCount;
        if (!_inventory.TryGetValue(name, out oldCount))
        {
            oldCount = 0;
            _inventory.Add(name, 0);
        }

        _inventory[name] += count;

        ItemChanged?.Invoke(name, oldCount, _inventory[name]);
    }

    public void RemoveItem(string name, int count)
    {
        int oldCount;
        if (!_inventory.TryGetValue(name, out oldCount))
        {
            oldCount = 0;
            _inventory.Add(name, 0);
        }

        _inventory[name] -= count;
        if (_inventory[name] < 0)
            _inventory[name] = 0;

        ItemChanged?.Invoke(name, oldCount, _inventory[name]);
    }
}
